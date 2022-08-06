using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour
{
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
