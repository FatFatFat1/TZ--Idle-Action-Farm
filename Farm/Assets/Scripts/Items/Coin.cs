using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _target;



    private void Awake()
    {
        _target = GameObject.FindGameObjectWithTag("MoneyCount").transform;
    }

    public void StartCoinMove(Vector3 _initial , Action onComplete)
    {
        Vector3 targetPos = Camera.main.ScreenToWorldPoint(new Vector3(_target.position.x, _target.position.y, Camera.main.transform.position.z * -1));
        StartCoroutine(MoveCoin(transform, _initial, targetPos , onComplete));
    }
    IEnumerator MoveCoin(Transform obj, Vector3 startPos, Vector3 endPos , Action onComplete)
    {
        float time = 0;
        while (time < 1)
        {
            time += _speed * Time.deltaTime;
            obj.position = Vector3.Lerp(startPos, endPos, time);
            yield return new WaitForEndOfFrame();
        }
        onComplete.Invoke();
        Destroy(gameObject);
    }

}
