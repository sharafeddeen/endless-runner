using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoins : MonoBehaviour
{
    public GameObject coinDisplay;
    public GameObject endCoin;
    public static int coinCount;
    public int internalCoin;

    void Update()
    {
        internalCoin = coinCount;
        coinDisplay.GetComponent<Text>().text = "" + coinCount;
    }

}
