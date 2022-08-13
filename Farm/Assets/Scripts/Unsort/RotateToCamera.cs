using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToCamera : MonoBehaviour
{
    private GameObject MainCamera;
    private void Awake()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    private void FixedUpdate()
    {
        SetRotate(gameObject , MainCamera);
    }
    void SetRotate(GameObject toRotate, GameObject camera)
    {
        transform.rotation =  Quaternion.Lerp(toRotate.transform.rotation, camera.transform.rotation, 1);
    }
}
