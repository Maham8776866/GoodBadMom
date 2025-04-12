using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScore : MonoBehaviour
{
    public int coins = 1;
    public int totalCoins;
    public TextMeshProUGUI coinsText;
    public void  CoinsAdded()
    {
        totalCoins += coins;

        coinsText.text = totalCoins.ToString();
       
       

    }


}
