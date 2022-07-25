using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soil : MonoBehaviour
{
    [SerializeField] private GameObject _seedData; // ������ �� ������ � �� ���� ��������
    [SerializeField] private int _seedTypeIndex;
    [SerializeField] private Seed _seedType;
    [SerializeField] private Seed[] mySlots;
    private SeedData sData; // ���� ��

    private void Awake()
    {
        sData = _seedData.GetComponent<SeedData>();
        GetMySeedType(); //� �� �� �������� ��� ��, ����� �� �� ����� ������, ���������� ��������� ����� ��������. ��� ���, ������ ������ ����� �����.

    }

    private void GetMySeedType()
    {
        _seedType = sData.Seed[_seedTypeIndex];
    }


}
