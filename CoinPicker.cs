using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Coin>(out Coin coin))
        {
            Score.CountOfCoins++;
            Destroy(coin.gameObject);
        }
    }
}
