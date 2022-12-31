using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class D20Roller : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public ParentPositionCheck posCheck;

    public GameObject player;
    public float displayTime = 3f;
    public int rollResult;
    public int newRollResult;

    public TextMeshProUGUI rollResultText; // reference to the text object that will display the roll result
    public TextMeshProUGUI encounterResultText; // reference to the text object that will display the encounter result


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

    }

    // This function is called when the roll button is clicked
    public void RollD20()
    {
        // Generate a random number between 1 and 20
        rollResult = Random.Range(1, 21);
        if(posCheck.isOnRH)
        {
            IsOnRH();
        }
        if(posCheck.isOnGB)
        {
            IsOnGB();
        }
        if(posCheck.isOnTW)
        {
            IsOnTW();
        }

        // Update the roll result text to show the result of the roll
        rollResultText.text = "You rolled a " + rollResult;
        rollResultText.gameObject.SetActive(true);



        Invoke("HideResultText", displayTime);
    }

    public void IsOnRH()
    {
        if (rollResult <= 5)
        {
            encounterResultText.text = "3 Bandits";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "2 Brush Thylacine";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "1 Hunter";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "2 Elk";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "2 Wolves";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "2 Boars";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "3 Thylacines";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Grizzly Bear";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnGB()
    {
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult <= 5)
            {
                encounterResultText.text = "3 Bandits";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "2 Brush Thylacine";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "1 Hunter";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "2 Elk";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "2 Wolves";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "2 Boars";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "3 Thylacines";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "1 Grizzly Bear";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "4 Mitflit Gremlins";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "2 Hunting Spiders";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "4 Stag Lord Bandits";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "2 Brush Thylacines";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "5 Kobolds";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "1 Owlbear";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "1 Shambler";
            encounterResultText.gameObject.SetActive(true);
        }
    }
    public void IsOnTW()
    {
        if (rollResult <= 5)
        {
            Debug.Log("Old Result: " + rollResult);
            newRollResult = Random.Range(1, 21);
            Debug.Log("New Result: " + newRollResult);
            if (newRollResult <= 5)
            {
                encounterResultText.text = "";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 5 && newRollResult < 9)
            {
                encounterResultText.text = "";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 8 && newRollResult < 12)
            {
                encounterResultText.text = "";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 11 && newRollResult < 14)
            {
                encounterResultText.text = "";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 13 && newRollResult < 16)
            {
                encounterResultText.text = "";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 15 && newRollResult < 18)
            {
                encounterResultText.text = "";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult > 17 && newRollResult < 20)
            {
                encounterResultText.text = "";
                encounterResultText.gameObject.SetActive(true);
            }
            if (newRollResult == 20)
            {
                encounterResultText.text = "";
                encounterResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult > 5 && rollResult < 9)
        {
            encounterResultText.text = "";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 8 && rollResult < 12)
        {
            encounterResultText.text = "";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 11 && rollResult < 14)
        {
            encounterResultText.text = "";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 13 && rollResult < 16)
        {
            encounterResultText.text = "";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 15 && rollResult < 18)
        {
            encounterResultText.text = "";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult > 17 && rollResult < 20)
        {
            encounterResultText.text = "";
            encounterResultText.gameObject.SetActive(true);
        }
        if (rollResult == 20)
        {
            encounterResultText.text = "";
            encounterResultText.gameObject.SetActive(true);
        }
    }


    private void HideResultText()
    {
        rollResultText.gameObject.SetActive(false);
        encounterResultText.gameObject.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Disable player movement when the button is clicked
        player.GetComponent<MoveParty>().StopMovement();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Enable player movement when the button is released
        player.GetComponent<MoveParty>().StartMovement();

        // Call the Roll method
        RollD20();
    }
}
