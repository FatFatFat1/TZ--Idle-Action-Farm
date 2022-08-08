using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Soil : MonoBehaviour
{
    [SerializeField] private GameObject _mySeed;
    [SerializeField] private Seed[] mySlots;


    public Seed[] MySlots => mySlots;
    public GameObject MySeed => _mySeed;
    private Seed _myType;
    private Vector3 _position;

    private void Awake()
    {
        _myType = MySeed.GetComponent<Seed>();
        _position = new Vector3(transform.position.x - 0.3f, transform.position.y - 1f, transform.position.z - 0.3f);
        if (_myType != null)
        {
            PlaceSeed(mySlots, _myType, _position);
        }

    }

    private void PlaceSeed(Seed[] Slots, Seed seedType, Vector3 pos)
    {
        for (int i = 0; i < Slots.Length; i++)
        {
            Slots[i] = Instantiate(seedType, pos, Quaternion.identity);
            //Slots[i].transform.Rotate(-90, 0, 0);
            pos = new Vector3(pos.x + 0.3f, pos.y, pos.z);
            if ((i + 1) % 3 == 0)
            {
                pos = new Vector3(pos.x - 0.9f, pos.y, pos.z + 0.3f);
            }
        }
    }

}
