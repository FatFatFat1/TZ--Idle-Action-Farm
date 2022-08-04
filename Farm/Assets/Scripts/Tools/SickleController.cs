using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SickleController : MonoBehaviour
{
    [SerializeField] public GameObject _myHand;

    private void FixedUpdate()
    {
        transform.position = _myHand.transform.position;
        transform.rotation = _myHand.transform.rotation;
    }
}
