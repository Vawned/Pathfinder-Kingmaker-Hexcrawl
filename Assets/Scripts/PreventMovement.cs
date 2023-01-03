using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PreventMovement : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
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
