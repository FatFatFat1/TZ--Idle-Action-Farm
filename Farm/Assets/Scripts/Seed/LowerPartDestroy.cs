using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerPartDestroy : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyWithTimer());
        StopCoroutine(DestroyWithTimer());
    }
    IEnumerator DestroyWithTimer()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
