using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sale : MonoBehaviour
{
    [SerializeField] private GameObject _myCoin;
    public GameObject MyCoin => _myCoin;
    public GameObject MyTimer;
    public GameObject MyScore;
    private Image _myImage;
    private Unloading _myStore;
    private Text _text;
    private int score;

    private void Awake()
    {
        _myImage = MyTimer.GetComponent<Image>();
        _myStore = GetComponent<Unloading>();
        _text = MyScore.GetComponent<Text>();
        StartCoroutine(Saling());
        score = 0;
    }
    IEnumerator Saling()
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
                        Vector3 coinPos = new Vector3(_myStore.MyStore[i].transform.position.x, _myStore.MyStore[i].transform.position.y + 0.5f, _myStore.MyStore[i].transform.position.z);
                        GameObject coin = Instantiate(MyCoin , coinPos, Quaternion.identity);
                        coin.GetComponent<Coin>().StartCoinMove(coinPos , () => 
                        {
                            _text.text = "Money:"+score+"$";
                        });
                    }
                }
                _myStore.Reset();
            }
            else
            {
                yield return new WaitForSeconds(1);
                _myImage.fillAmount -= 0.05f;
            }
        }
    }
}
