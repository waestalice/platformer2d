using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HUD_Coins : MonoBehaviour
{
    [SerializeField] private TMP_Text textCoins;


    void Update()
    {
        int coins = ItemManager.Instance.coins;

        textCoins.text = "x " + coins;
    }

    public void OnCollect()
    {
        textCoins.text = "x " + ItemManager.Instance.coins;
    }
}
