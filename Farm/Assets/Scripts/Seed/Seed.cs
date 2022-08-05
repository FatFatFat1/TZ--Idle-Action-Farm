using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private float _timeOfGrow;
    [SerializeField] private float _timeOfHarvest;
    public string Name => _name;

    public bool isMature;
    public float TimeOfGrow => _timeOfGrow; // Время за которое растение достигает финальной стадии роста
    public float TimeOfHarvest => _timeOfHarvest;
    public Vector3 EndGrowPositon;
    public GameObject MyHarvest; // Результат сбора
    public float Distance;
    public void Grow(float time, Vector3 endPos)
    {
        Vector3 speed = Vector3.up * time * Time.deltaTime;
        if (transform.position.y <= endPos.y && isMature == false)
        {
            transform.Translate(speed);
        }
        if (transform.position.y > endPos.y)
        {
            transform.Translate(-speed);
            isMature = true;
        }
    }
}