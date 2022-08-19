using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinsText;

    public static int CountOfCoins = 0;

    private void Update()
    {
        _coinsText.text = CountOfCoins.ToString();
    }
}