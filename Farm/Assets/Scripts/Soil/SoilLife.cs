using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilLife : MonoBehaviour
{
    public Seed[] MySoilSlots;

    private void Awake()
    {
        MySoilSlots = GetComponent<Soil>().MySlots;
        for (int i = 0; i < MySoilSlots.Length; i++)
        {
            MySoilSlots[i].EndGrowPositon = MySoilSlots[i].transform.position + MySoilSlots[i].EndGrowPositon;
        }
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < MySoilSlots.Length; i++)
        {
            if (!MySoilSlots[i].isMature)
            {
                MySoilSlots[i].Grow(MySoilSlots[i].TimeOfGrow, MySoilSlots[i].EndGrowPositon);
            }
        }
    }

}