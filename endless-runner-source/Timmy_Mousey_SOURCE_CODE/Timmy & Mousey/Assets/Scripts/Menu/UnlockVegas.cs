using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockVegas : MonoBehaviour
{

    public GameObject playerVegas;
    public static int isVisible;
    public static bool saveExtra;

    void Start()
    {
        isVisible = PlayerPrefs.GetInt("BigVegasUnlock");
        if (isVisible == 1)
        {
            playerVegas.SetActive(true);
        }
    }

    void Update()
    {
        if (saveExtra == true)
        {
            saveExtra = false;
            isVisible = 1;
            playerVegas.SetActive(true);
            PlayerPrefs.SetInt("BigVegasUnlock", 1);
        }
    }

}
