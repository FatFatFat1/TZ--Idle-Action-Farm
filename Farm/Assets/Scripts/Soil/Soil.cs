using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soil : MonoBehaviour
{
    [SerializeField] private GameObject _seedData; // ссылка на объект с БД всех растений
    [SerializeField] private int _seedTypeIndex;
    [SerializeField] private Seed _seedType;
    [SerializeField] private Seed[] mySlots;
    private SeedData sData; // само БД

    private void Awake()
    {
        sData = _seedData.GetComponent<SeedData>();
        GetMySeedType(); //В тз не написано про то, можно ли на одной грядке, выращивать несколько видов растений. Так что, сделал только одним типом.

    }

    private void GetMySeedType()
    {
        _seedType = sData.Seed[_seedTypeIndex];
    }


}
