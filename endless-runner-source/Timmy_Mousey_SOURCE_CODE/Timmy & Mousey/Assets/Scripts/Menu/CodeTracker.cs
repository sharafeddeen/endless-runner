using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeTracker : MonoBehaviour
{
    public GameObject redeemButton;
    public GameObject codeEnter;
    public GameObject codeHolder;
    public string codeR;
    //all possible codes - enter your own here
    public string cP01 = "CODE001";
    public string cP02 = "CODE002";
    public string cP03 = "CODE003";
    public string cP04 = "CODE004";
    public string cP05 = "CODE005";
    public string cP06 = "CODE006";
    public string cP07 = "CODE007";
    public string cP08 = "CODE008";
    public string cY01 = "CODE009";
    public string cY02 = "CODE010";
    public string cY03 = "CODE011";
    public string cY04 = "CODE012";
    public string cY05 = "CODE013";
    public string cY06 = "CODE014";
    public string cY07 = "CODE015";
    public string cY08 = "CODE016";
    public string cG01 = "CODE017";
    public string cG02 = "CODE018";
    public string cG03 = "CODE019";
    public string cG04 = "CODE020";
    public string cG05 = "CODE021";
    public string cE01 = "CODE022";
    public string cE02 = "CODE023";
    public string cE03 = "CODE024";
    public AudioSource tillPurchase;
    public int gemCount;
    public int coinCount;
    public int codeVal01;
    public int codeVal02;
    public int codeVal03;
    public int codeVal04;
    public int codeVal05;
    public int codeVal06;
    public int codeVal07;
    public int codeVal08;
    public int codeVal09;
    public int codeVal10;
    public int codeVal11;
    public int codeVal12;
    public int codeVal13;
    public int codeVal14;
    public int codeVal15;
    public int codeVal16;
    public int codeVal17;
    public int codeVal18;
    public int codeVal19;
    public int codeVal20;
    public int codeVal21;
    public int codeVal22;
    public int codeVal23;
    public int codeVal24;

    void Start()
    {
        codeVal01 = PlayerPrefs.GetInt("CodeA");
        codeVal02 = PlayerPrefs.GetInt("CodeB");
        codeVal03 = PlayerPrefs.GetInt("CodeC");
        codeVal04 = PlayerPrefs.GetInt("CodeD");
        codeVal05 = PlayerPrefs.GetInt("CodeE");
        codeVal06 = PlayerPrefs.GetInt("CodeF");
        codeVal07 = PlayerPrefs.GetInt("CodeG");
        codeVal08 = PlayerPrefs.GetInt("CodeH");
        codeVal09 = PlayerPrefs.GetInt("CodeI");
        codeVal10 = PlayerPrefs.GetInt("CodeJ");
        codeVal11 = PlayerPrefs.GetInt("CodeK");
        codeVal12 = PlayerPrefs.GetInt("CodeL");
        codeVal13 = PlayerPrefs.GetInt("CodeM");
        codeVal14 = PlayerPrefs.GetInt("CodeN");
        codeVal15 = PlayerPrefs.GetInt("CodeO");
        codeVal16 = PlayerPrefs.GetInt("CodeP");
        codeVal17 = PlayerPrefs.GetInt("CodeQ");
        codeVal18 = PlayerPrefs.GetInt("CodeR");
        codeVal19 = PlayerPrefs.GetInt("CodeS");
        codeVal20 = PlayerPrefs.GetInt("CodeT");
        codeVal21 = PlayerPrefs.GetInt("CodeU");
        codeVal22 = PlayerPrefs.GetInt("CodeV");
        codeVal23 = PlayerPrefs.GetInt("CodeW");
        codeVal24 = PlayerPrefs.GetInt("CodeX");
    }

    void Update()
    {
        codeR = codeEnter.GetComponent<Text>().text;
        if (codeR == cP01 || codeR == cP02 || codeR == cP03 || codeR == cP04 || codeR == cP05 || codeR == cP06 || codeR == cP07 || codeR == cP08 || codeR == cY01 || codeR == cY02 || codeR == cY03 || codeR == cY04 || codeR == cY05 || codeR == cY06 || codeR == cY07 || codeR == cY08 || codeR == cG01 || codeR == cG02 || codeR == cG03 || codeR == cG04 || codeR == cG05 || codeR == cE01 || codeR == cE02 || codeR == cE03)
        {
            if (codeR == cP01 && codeVal01 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cP02 && codeVal02 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cP03 && codeVal03 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cP04 && codeVal04 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cP05 && codeVal05 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cP06 && codeVal06 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cP07 && codeVal07 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cP08 && codeVal08 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cY01 && codeVal09 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cY02 && codeVal10 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cY03 && codeVal11 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cY04 && codeVal12 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cY05 && codeVal13 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cY06 && codeVal14 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cY07 && codeVal15 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cY08 && codeVal16 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cG01 && codeVal17 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cG02 && codeVal18 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cG03 && codeVal19 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cG04 && codeVal20 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cG05 && codeVal21 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cE01 && codeVal22 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cE02 && codeVal23 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
            if (codeR == cE03 && codeVal24 == 0)
            {
                redeemButton.GetComponent<Button>().interactable = true;
            }
        }
        else
        {
            redeemButton.GetComponent<Button>().interactable = false;
        }
    }

    public void RedeemButton()
    {
        if (codeR == cP01 && codeVal01 == 0)
        {
            codeVal01 = 1;
            PlayerPrefs.SetInt("CodeA", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 1000;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cP02 && codeVal02 == 0)
        {
            codeVal02 = 1;
            PlayerPrefs.SetInt("CodeB", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            gemCount += 10;
            PlayerPrefs.SetInt("TotalGems", gemCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cP03 && codeVal03 == 0)
        {
            codeVal03 = 1;
            PlayerPrefs.SetInt("CodeC", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 500;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cP04 && codeVal04 == 0)
        {
            codeVal04 = 1;
            PlayerPrefs.SetInt("CodeD", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 750;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cP05 && codeVal05 == 0)
        {
            codeVal05 = 1;
            PlayerPrefs.SetInt("CodeE", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            gemCount += 15;
            PlayerPrefs.SetInt("TotalGems", gemCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cP06 && codeVal06 == 0)
        {
            codeVal06 = 1;
            PlayerPrefs.SetInt("CodeF", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 1200;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cP07 && codeVal07 == 0)
        {
            codeVal07 = 1;
            PlayerPrefs.SetInt("CodeG", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 400;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cP08 && codeVal08 == 0)
        {
            codeVal08 = 1;
            PlayerPrefs.SetInt("CodeH", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            gemCount += 20;
            PlayerPrefs.SetInt("TotalGems", gemCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cY01 && codeVal09 == 0)
        {
            codeVal09 = 1;
            PlayerPrefs.SetInt("CodeI", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 1000;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cY02 && codeVal10 == 0)
        {
            codeVal10 = 1;
            PlayerPrefs.SetInt("CodeJ", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            gemCount += 10;
            PlayerPrefs.SetInt("TotalGems", gemCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cY03 && codeVal11 == 0)
        {
            codeVal11 = 1;
            PlayerPrefs.SetInt("CodeK", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 500;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cY04 && codeVal12 == 0)
        {
            codeVal12 = 1;
            PlayerPrefs.SetInt("CodeL", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 750;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cY05 && codeVal13 == 0)
        {
            codeVal13 = 1;
            PlayerPrefs.SetInt("CodeM", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            gemCount += 15;
            PlayerPrefs.SetInt("TotalGems", gemCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cY06 && codeVal14 == 0)
        {
            codeVal14 = 1;
            PlayerPrefs.SetInt("CodeN", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 1200;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cY07 && codeVal15 == 0)
        {
            codeVal15 = 1;
            PlayerPrefs.SetInt("CodeO", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 400;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cY08 && codeVal16 == 0)
        {
            codeVal16 = 1;
            PlayerPrefs.SetInt("CodeP", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            gemCount += 20;
            PlayerPrefs.SetInt("TotalGems", gemCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cG01 && codeVal17 == 0)
        {
            codeVal17 = 1;
            PlayerPrefs.SetInt("CodeQ", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 1000;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cG02 && codeVal18 == 0)
        {
            codeVal18 = 1;
            PlayerPrefs.SetInt("CodeR", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 1000;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cG03 && codeVal19 == 0)
        {
            codeVal19 = 1;
            PlayerPrefs.SetInt("CodeS", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            gemCount += 15;
            PlayerPrefs.SetInt("TotalGems", gemCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cG04 && codeVal20 == 0)
        {
            codeVal20 = 1;
            PlayerPrefs.SetInt("CodeT", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 1000;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cG05 && codeVal21 == 0)
        {
            codeVal21 = 1;
            PlayerPrefs.SetInt("CodeU", 1);
            coinCount = PlayerPrefs.GetInt("TotalCoins");
            gemCount = PlayerPrefs.GetInt("TotalGems");
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            coinCount += 2500;
            PlayerPrefs.SetInt("TotalCoins", coinCount);
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cE01 && codeVal22 == 0)
        {
            codeVal22 = 1;
            PlayerPrefs.SetInt("CodeV", 1);
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            UnlockVegas.isVisible = 1;
            UnlockVegas.saveExtra = true;
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cE02 && codeVal23 == 0)
        {
            codeVal23 = 1;
            PlayerPrefs.SetInt("CodeW", 1);
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            UnlockMaria.isVisible = 1;
            UnlockMaria.saveExtra = true;
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }

        if (codeR == cE03 && codeVal24 == 0)
        {
            codeVal24 = 1;
            PlayerPrefs.SetInt("CodeX", 1);
            tillPurchase.Play();
            codeHolder.GetComponent<InputField>().text = "";
            UnlockBlock.isVisible = 1;
            UnlockBlock.saveExtra = true;
            LoadAllValuesIn.updateStats = true;
            GlobalStore.refreshPurchase = true;
        }
    }

}
