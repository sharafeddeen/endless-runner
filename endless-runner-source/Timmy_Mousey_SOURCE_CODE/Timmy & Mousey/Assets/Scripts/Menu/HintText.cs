using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintText : MonoBehaviour
{
    public int numberGen;
    public string displayText;
    public GameObject textObject;
    public bool displayingHint = false;

    void Update()
    {
        if (displayingHint == false)
        {
            displayingHint = true;
            numberGen = Random.Range(1, 11);
            if (numberGen == 1)
            {
                displayText = "No more Lives? You can buy some more in the store with your coins!";
            }
            if (numberGen == 2)
            {
                displayText = "No more Coins? Play the bonus game to earn some more!";
            }
            if (numberGen == 3)
            {
                displayText = "Buy Gems with your Coins in the Store!";
            }
            if (numberGen == 4)
            {
                displayText = "Want everything unlocked? Get the UNLOCKED version of the game on http://itch.io";
            }
            if (numberGen == 5)
            {
                displayText = "Make your own version of this game by getting the full source code on http://itch.io";
            }
            if (numberGen == 6)
            {
                displayText = "Unlockable characters have some extra abilities!";
            }
            if (numberGen == 7)
            {
                displayText = "Unlock all the Achievements for something super secret!";
            }
            if (numberGen == 8)
            {
                displayText = "Buy Lives as early as possible so you never run out!";
            }
            if (numberGen == 9)
            {
                displayText = "Want a code for the store? Look up Jimmy Vegas on YouTube or Patreon!";
            }
            if (numberGen == 10)
            {
                displayText = "Like the tunes? Get the soundtrack on htt://itch.io";
            }
            StartCoroutine(CycleText());
        }
    }

    IEnumerator CycleText()
    {
        textObject.GetComponent<Text>().text = "" + displayText;
        textObject.GetComponent<Animator>().Play("MenuScrollAnim");
        yield return new WaitForSeconds(6.5f);
        textObject.GetComponent<Animator>().Play("New State");
        displayingHint = false;

    }
}
