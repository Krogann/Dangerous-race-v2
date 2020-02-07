using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPiker : MonoBehaviour
{
    //script à mettre sur le player
    private float coin = 0;
    
    public TextMeshProUGUI textCoin;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coin ++;
            textCoin.text = coin.ToString();
            Destroy(other.gameObject);
        }
    }
}
