using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public void StartAddScore(int oldScore, int currentScore, Text text)
    {
        StartCoroutine(AddScore(oldScore , currentScore, text));
    }
    IEnumerator AddScore(int oldScore, int currentScore , Text text)
    {
        for (int i = oldScore; i <= currentScore; i++)
        {
            text.text = "Money:" + i + "$";
            yield return new WaitForEndOfFrame();
        }
    }
}
