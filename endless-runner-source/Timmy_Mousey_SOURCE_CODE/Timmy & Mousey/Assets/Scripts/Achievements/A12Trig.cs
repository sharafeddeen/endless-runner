﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A12Trig : MonoBehaviour
{
    public GameObject AchUI;

    void Start()
    {
        if (GlobalAchievements.A12 == 0)
        {
            GlobalAchievements.A12 = 1;
            GlobalAchievements.saveAchievements = true;
            StartCoroutine(ActivateAch());
        }
    }

    IEnumerator ActivateAch()
    {
        yield return new WaitForSeconds(2);
        AchUI.SetActive(true);
        yield return new WaitForSeconds(4);
        AchUI.SetActive(false);
    }
}