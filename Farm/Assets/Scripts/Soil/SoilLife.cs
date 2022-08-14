using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilLife : MonoBehaviour
{
    public Seed[] MySoilSlots;
    private float _seconds;

    private void Start()
    {
        MySoilSlots = GetComponent<Soil>().MySlots;
        for (int i = 0; i < MySoilSlots.Length; i++)
        {
            MySoilSlots[i].EndGrowPositon = MySoilSlots[i].transform.position + MySoilSlots[i].EndGrowPositon;
            MySoilSlots[i].Distance = Vector3.Distance(MySoilSlots[i].transform.position, MySoilSlots[i].EndGrowPositon);
        }
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < MySoilSlots.Length; i++)
        {
            if (!MySoilSlots[i].isMature)
            {
                _seconds = MySoilSlots[i].Distance / MySoilSlots[i].TimeOfGrow;
                MySoilSlots[i].Grow(_seconds, MySoilSlots[i].EndGrowPositon);
            }
        }
    }

}