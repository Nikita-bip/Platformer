using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private float _spawnHeight;
    [SerializeField] private int _countOfCoins;

    private void Start()
    {
        var size = GetComponent<SpriteRenderer>().sprite.bounds.size.x * transform.localScale.x;
        var step = 1;

        for (int i = 1; i <= _countOfCoins; i++)
        {
            Instantiate(_coin, transform.position + new Vector3(step * i - size / 2f,  _spawnHeight), Quaternion.identity);
        }
    }
}
