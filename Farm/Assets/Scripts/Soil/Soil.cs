using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Soil : MonoBehaviour
{
    [SerializeField] private GameObject _seedData; // ссылка на объект с БД всех растений
    [SerializeField] private int _seedTypeIndex;
    [SerializeField] private Seed _seedType;
    [SerializeField] private Seed[] mySlots;

    public Seed[] MySlots => mySlots;
    private SeedData sData; // само БД
    private Vector3 _position;

    private void Awake()
    {
        sData = _seedData.GetComponent<SeedData>();
        GetMySeedType(); //В тз не написано про то, можно ли на одной грядке, выращивать несколько видов растений. Так что, в одной грядке только один вид растений.
        _position = new Vector3(transform.position.x - 0.3f, transform.position.y + 0.5f, transform.position.z - 0.3f);
        PlaceSeed(mySlots, _seedType, _position);
    }

    private void GetMySeedType()
    {
        _seedType = sData.Seed[_seedTypeIndex];
    }

    private void PlaceSeed(Seed[] Slots, Seed seedType, Vector3 pos)
    {
        for (int i = 0; i < Slots.Length; i++)
        {
            Slots[i] = Instantiate(seedType, pos, Quaternion.identity);
            pos = new Vector3(pos.x + 0.3f, pos.y, pos.z);
            if ((i+1) % 3 == 0)
            {
                pos = new Vector3(pos.x - 0.9f , pos.y , pos.z + 0.3f);
            }
        }
    }

}
