using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedData : MonoBehaviour
{
    [SerializeField] private Seed[] _seed;
    public Seed[] Seed => _seed;
}