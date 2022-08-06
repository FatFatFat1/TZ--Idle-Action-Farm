using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    [SerializeField] private int _maxSlots;
    public bool isFull;
    public int CurrentBlock = 0;
    public int MaxSlots => _maxSlots;
    public GameObject[] myHarvest;

    public void TryStorage(GameObject block)
    {
        if (!isFull)
        {
            myHarvest[CurrentBlock] = block;
        }
        if (myHarvest[CurrentBlock]!= null)
        {
            myHarvest[CurrentBlock].transform.parent = gameObject.transform;
            myHarvest[CurrentBlock].transform.rotation = new Quaternion(0, 0, 0, 0);
            myHarvest[CurrentBlock].transform.localPosition = Vector3.zero;
            myHarvest[CurrentBlock].transform.localPosition += new Vector3(0, 1 + 0.25f * CurrentBlock, -0.25f);
            myHarvest[CurrentBlock].GetComponent<Rigidbody>().isKinematic = true;
        }
        if (CurrentBlock > MaxSlots)
        {
            isFull = true;
        }
        CurrentBlock++;
    }
}
