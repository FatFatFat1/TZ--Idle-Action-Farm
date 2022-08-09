using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sale : MonoBehaviour
{
    public GameObject MyTimer;
    public GameObject MyScore;
    private Image _myImage;
    private Text _myText;
    private Unloading _myStore;
    private int score;

    private void Awake()
    {
        _myImage = MyTimer.GetComponent<Image>();
        _myText = MyScore.GetComponent<Text>();
        _myStore = GetComponent<Unloading>();
        StartCoroutine(Saling(MyTimer));
        score = 0;
    }

    IEnumerator Saling(GameObject myHarvest)
    {
        while (true)
        {
            if (_myImage.fillAmount == 0)
            {
                yield return new WaitForSeconds(1);
                _myImage.fillAmount = 1;
                for (int i = 0; i < _myStore.MyStore.Length; i++)
                {
                    if (_myStore.MyStore[i] != null)
                    {
                        score += _myStore.MyStore[i].GetComponent<Harvest>().Cost;
                    }
                }
                _myStore.Reset();
                _myText.text = "Money:" + score + "$";
            }
            else
            {
                yield return new WaitForSeconds(1);
                _myImage.fillAmount -= 0.05f;
            }
        }
    }
}
