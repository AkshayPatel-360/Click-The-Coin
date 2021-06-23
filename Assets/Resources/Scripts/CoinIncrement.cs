using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinIncrement : MonoBehaviour
{
    [SerializeField]private Text ui;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        ui.text = "₿x" + GameManager.CoinMultiplayer + " : " + GameManager.BitCoin + " ₿";
    }

    public void ClickIncrement()
    {
        GameManager.BitCoin += GameManager.CoinMultiplayer;
    }

    public void MultiplayerIncrement(int num)
    {
        if (GameManager.BitCoin >= 10 && num == 1  )
        {
            GameManager.CoinMultiplayer += 2;
            GameManager.BitCoin -= 10;
        }

        if (GameManager.BitCoin >= 100 && num == 2)
        {
            GameManager.CoinMultiplayer += 5;
            GameManager.BitCoin -= 100;
        }

        if (GameManager.BitCoin >= 1000 && num == 3)
        {
            GameManager.CoinMultiplayer += 10;
            GameManager.BitCoin -= 1000;
        }

        if (GameManager.BitCoin >= 10000 && num == 4)
        {
            GameManager.CoinMultiplayer += 50;
            GameManager.BitCoin -= 10000;
        }


    }
}
