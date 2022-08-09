using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour
{
    [SerializeField] private int _cost;
    public int Cost => _cost; // Сколько стоит продажа блока в амбаре
    private Backpack _myBackpack;


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            _myBackpack = col.gameObject.GetComponent<Backpack>();
            _myBackpack.TryStorage(gameObject);
        }
    }
}
