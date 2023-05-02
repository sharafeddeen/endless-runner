using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectCollision : MonoBehaviour
{
    public GameObject theCharacter;
    // public GameObject dustParts;
    public GameObject theCamera;
    public AudioSource collideEffect;
    public GameObject footSteps;
    public GameObject fadeOut;
    public GameObject endPanel;
    public GameObject[] scoringPanels;
    //playerprefs for saving
    public int importedDistance;
    public int importedCoins;
    public static bool pressToContinue;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collide")
        {
            footSteps.SetActive(false);
            this.gameObject.GetComponent<PlayerControl>().enabled = false;
            GlobalCollisionDetect.hasCollided = true;
            collideEffect.Play();
            theCamera.GetComponent<Animator>().enabled = true;
            theCharacter.GetComponent<Animator>().Play("Stumble Backwards");
            
#pragma warning disable CS0618
            //dustParts.GetComponent<ParticleSystem>().startSize = 0;
#pragma warning restore CS0618
            StartCoroutine(ResetGame());
        }
    }

    IEnumerator ResetGame()
    {
        yield return new WaitForSeconds(3);
        //obtain previous values
        importedCoins = PlayerPrefs.GetInt("TotalCoins");
        //add current values
        //save new values
        PlayerPrefs.SetInt("TotalCoins", importedCoins);
        //continue as normal
        endPanel.SetActive(true);
        pressToContinue = true;
        scoringPanels[0].SetActive(false);
        scoringPanels[1].SetActive(false);
        scoringPanels[2].SetActive(false);
        scoringPanels[3].SetActive(false);
        scoringPanels[4].SetActive(false);
        scoringPanels[5].SetActive(false);
        yield return new WaitForSeconds(1);
        //SceneManager.LoadScene(0);
    }

}
