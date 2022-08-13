using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Unloading : MonoBehaviour
{
    [SerializeField] private int _maxBlock;
    public int MaxBlock => _maxBlock;
    public GameObject[] MyStore;
    private Backpack _myBackPack;
    private Vector3 _currentPos;
    private int _currentStep;

    private void Awake()
    {
        _currentPos = transform.position + new Vector3(-2, 0.25f, -0.5f);
        _currentStep = 1;
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            _myBackPack = col.gameObject.GetComponent<Backpack>();
            for (int i = 0; i < _myBackPack.myHarvest.Length; i++)
            {
                if (_myBackPack.myHarvest[i] != null)
                {
                    Unload(_myBackPack.myHarvest[i], _myBackPack, i);
                    _currentPos += new Vector3(+0.25f, 0, -0);
                    if (_currentStep % 10 == 0)
                    {
                        _currentPos += new Vector3(-2.5f, 0, +0.25f);
                    }
                    _currentStep++;
                }
            }
        }
    }

    private void Unload(GameObject block, Backpack myBack, int i)
    {
        block.transform.parent = null;
        myBack.myHarvest[i] = null;
        StartCoroutine(BlockFly(block, block.transform.position, _currentPos));
        MyStore[_currentStep - 1] = block;
        myBack.CurrentBlock--;
        myBack.myText.GetComponent<TMP_Text>().text = myBack.CurrentBlock + "/" + (myBack.MaxSlots + 1);
    }

    IEnumerator BlockFly(GameObject block, Vector3 startPos, Vector3 endPos)
    {
        float time = 0;
        while (time < 1)
        {
            time += 1 * Time.deltaTime;
            block.transform.position = Vector3.Lerp(startPos, endPos, time);
            yield return new WaitForEndOfFrame();
        }
    }
    public void Reset()
    {
        _currentPos = transform.position + new Vector3(-2, 0.25f, -0.5f);
        _currentStep = 1;
        for (int i = 0; i < MyStore.Length; i++)
        {
            Destroy(MyStore[i]);
            MyStore[i] = null;
        }
    }
}
