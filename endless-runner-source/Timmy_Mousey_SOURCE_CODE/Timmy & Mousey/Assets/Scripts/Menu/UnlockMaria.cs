using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockMaria : MonoBehaviour
{

    public GameObject playerMaria;
    public static int isVisible;
    public static bool saveExtra;

    void Start()
    {
        isVisible = PlayerPrefs.GetInt("MariaPlayable");
        if (isVisible == 1)
        {
            playerMaria.SetActive(true);
        }
    }

    void Update()
    {
        if (saveExtra == true)
        {
            saveExtra = false;
            isVisible = 1;
            playerMaria.SetActive(true);
            PlayerPrefs.SetInt("MariaPlayable", 1);
        }
    }

}
