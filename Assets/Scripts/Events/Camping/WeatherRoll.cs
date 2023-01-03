using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WeatherRoll : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
    public float displayTime = 3f;
    public int rollResult;
    public int newRollResult;
    public bool noResultText;
    public TextMeshProUGUI criticalWeatherText;


    public TextMeshProUGUI rollResultText; // reference to the text object that will display the roll result
    public TextMeshProUGUI weatherResultText; // reference to the text object that will display the weather result

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void RollWeather()
    {
        rollResult = Random.Range(1, 21);
        newRollResult = Random.Range(1, 21);
        if (!noResultText)
        {
            if (rollResult >= 17 && rollResult < 21)
            {
                if (rollResult == 20)
                {
                    criticalWeatherText.text = "Critical Weather";
                    criticalWeatherText.gameObject.SetActive(true);
                }
                if (newRollResult <= 3)
                {
                    weatherResultText.text = "Fog";
                    weatherResultText.gameObject.SetActive(true);
                }
                if (newRollResult > 3 && newRollResult < 8)
                {
                    weatherResultText.text = "Heavy Downpour";
                    weatherResultText.gameObject.SetActive(true);
                }
                if (newRollResult > 7 && newRollResult < 10)
                {
                    weatherResultText.text = "Cold Snap";
                    weatherResultText.gameObject.SetActive(true);
                }
                if (newRollResult > 9 && newRollResult < 13)
                {
                    weatherResultText.text = "Windstorm";
                    weatherResultText.gameObject.SetActive(true);
                }
                if (newRollResult == 13)
                {
                    weatherResultText.text = "Severe Hailstorm";
                    weatherResultText.gameObject.SetActive(true);
                }
                if (newRollResult == 14)
                {
                    weatherResultText.text = "Blizzard";
                    weatherResultText.gameObject.SetActive(true);
                }
                if (newRollResult == 15)
                {
                    weatherResultText.text = "Supernatural Storm";
                    weatherResultText.gameObject.SetActive(true);
                }
                if (newRollResult == 16)
                {
                    weatherResultText.text = "Flash Flood";
                    weatherResultText.gameObject.SetActive(true);
                }
                if (newRollResult == 17)
                {
                    weatherResultText.text = "Wildfire";
                    weatherResultText.gameObject.SetActive(true);
                }
                if (newRollResult == 18)
                {
                    weatherResultText.text = "Subsidence";
                    weatherResultText.gameObject.SetActive(true);
                }
                if (newRollResult == 19)
                {
                    weatherResultText.text = "Thunderstorm";
                    weatherResultText.gameObject.SetActive(true);
                }
                if (newRollResult == 20)
                {
                    weatherResultText.text = "Tornado";
                    weatherResultText.gameObject.SetActive(true);
                }
                rollResultText.text = "You rolled: " + newRollResult;
                rollResultText.gameObject.SetActive(true);
            }
        }
        if (rollResult < 17)
        {
            weatherResultText.text = "No change in weather";
            weatherResultText.gameObject.SetActive(true);
            rollResultText.text = "You rolled: " + rollResult;
        }
        else
        {
            rollResultText.text = "You rolled: " + newRollResult;
            rollResultText.gameObject.SetActive(true);
        }
        
        Invoke("HideResultText", displayTime);
    }

    public void ShowResultText()
    {
        noResultText = !noResultText;
    }
    private void HideResultText()
    {
        rollResultText.gameObject.SetActive(false);
        weatherResultText.gameObject.SetActive(false);
        criticalWeatherText.gameObject.SetActive(false);
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
    }
}
