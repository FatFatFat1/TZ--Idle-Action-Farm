using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    private Animator _myAnimator;
    private void Awake()
    {
        _myAnimator = GetComponent<Animator>();
    }
    public void Harvest()
    {
        _myAnimator.Play("Harvest");
    }

}
