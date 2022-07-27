using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilLife : MonoBehaviour
{
    public GameObject MySoil;
    public Seed[] MySoilSlots;

    private void Awake()
    {
        MySoilSlots = MySoil.GetComponent<Soil>().MySlots;
    }
}
