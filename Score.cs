using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int _coins = 0;
    public TMP_Text coinsText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Coin>(out Coin coin))
        {
            PickCoin(coin);
        }
    }

    private void PickCoin(Coin coin)
    {
        _coins++;
        DisplayInfo();
        Destroy(coin.gameObject);
    }

    private void DisplayInfo()
    {
        coinsText.text = _coins.ToString();
    }
    
}
