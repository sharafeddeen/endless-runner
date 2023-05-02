using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollectCoin : MonoBehaviour
{
    void OnTriggerEnter (Collider other)
    {
        Console.WriteLine("Coin collected!");
        CollectableControl.coinCount++;
        this.gameObject.SetActive(false);
    }
}
