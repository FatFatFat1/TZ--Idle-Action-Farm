using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private int _stateOfGrow;
    [SerializeField] private int _maxStateOfGrow;
    [SerializeField] private int _timeOfGrow;

    public string Name => _name;
    public int StateOfGrow => _stateOfGrow; // ������� ������ �����
    public int MaxStateOfGrow => _maxStateOfGrow; // ������� ������ �����
    public int TimeOfGrow => _timeOfGrow; // ����� �� ������� �������� ��������� ��������� ������ �����
}
