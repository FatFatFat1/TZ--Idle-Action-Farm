using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedDestroy : MonoBehaviour
{
    public GameObject MyHarvest;
    void Start()
    {
        StartCoroutine(Harvesting(MyHarvest));
        StopCoroutine(Harvesting(MyHarvest));
    }
    IEnumerator Harvesting(GameObject myHarvest)
    {
        yield return new WaitForSeconds(4);
        Instantiate(myHarvest, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 2, gameObject.transform.position.z), gameObject.transform.rotation);
        Destroy(gameObject);
    }
}
