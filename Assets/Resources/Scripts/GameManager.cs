using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int BitCoin { get; set; }
    public static int CoinMultiplayer { get; set; }

    void Start()
    {
        BitCoin = PlayerPrefs.GetInt("BitCoin",0);
        CoinMultiplayer = PlayerPrefs.GetInt("CoinMultiplayer", 1);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
        
    }
}
