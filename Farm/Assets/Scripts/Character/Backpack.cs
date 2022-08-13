using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Backpack : MonoBehaviour
{
    [SerializeField] private int _maxSlots;
    public bool isFull;
    public int CurrentBlock = 0;
    public int MaxSlots => _maxSlots;
    public GameObject MySpine;
    public GameObject myText;
    public GameObject[] myHarvest;

    public void TryStorage(GameObject block)
    {
        if (!isFull)
        {
            myHarvest[CurrentBlock] = block;
        }
        if (myHarvest[CurrentBlock]!= null)
        {
            myHarvest[CurrentBlock].transform.parent = MySpine.transform;
            myHarvest[CurrentBlock].transform.rotation = new Quaternion(0, 0, 0, 0);
            myHarvest[CurrentBlock].transform.localPosition = Vector3.zero;
            myHarvest[CurrentBlock].transform.localPosition += new Vector3(0,0.25f * CurrentBlock, -0.25f);
            myHarvest[CurrentBlock].GetComponent<Rigidbody>().isKinematic = true;
            myText.GetComponent<TMP_Text>().text = (CurrentBlock+1) + "/"+ (MaxSlots+1);
        }
        if (CurrentBlock > MaxSlots)
        {
            isFull = true;
        }
        CurrentBlock++;
    }
}
