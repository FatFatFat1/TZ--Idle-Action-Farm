using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private int _stateOfGrow;
    [SerializeField] private int[][] _seedLocation;

    public string Name => _name;
    public int StateOfGrow => _stateOfGrow; // 0 только посаженно , 2 готово к сбору
    public int[][] SeedLocation => _seedLocation; //Местонахождение ростка на грядке

}
