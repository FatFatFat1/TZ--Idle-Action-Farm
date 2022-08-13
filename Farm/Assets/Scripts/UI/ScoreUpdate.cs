using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    Vector3 truePos;
    private void Awake()
    {
        truePos = gameObject.transform.position;
    }
    public void StartAddScore(int oldScore, int currentScore, Text text)
    {
        StartCoroutine(AddScore(oldScore, currentScore, text));
    }
    IEnumerator AddScore(int oldScore, int currentScore, Text text)
    {
        for (int i = oldScore; i <= currentScore; i++)
        {
            Vector3 randPos;
            randPos = new Vector3(gameObject.transform.position.x + Random.Range(-0.5f, 0.5f), gameObject.transform.position.y + Random.Range(-0.5f, 0.5f), gameObject.transform.position.z + Random.Range(-0.5f, 0.5f));
            gameObject.transform.position = randPos;
            text.text = "Money:" + i + "$";
            yield return new WaitForEndOfFrame();
        }
        gameObject.transform.position = truePos;
    }
}
