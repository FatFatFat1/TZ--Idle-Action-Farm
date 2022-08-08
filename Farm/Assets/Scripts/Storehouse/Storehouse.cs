using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storehouse : MonoBehaviour
{
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
                        Debug.Log("Новая строка");
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
        block.transform.position = _currentPos;
        myBack.CurrentBlock--;
    }
}
