using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckSecrets : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
    public GameObject[] secrets;

    public void Start() 
    {
        secrets = GameObject.FindGameObjectsWithTag("Secret");
        player = GameObject.FindWithTag("Player");
    }

    public void Reveal()
    {
        foreach (GameObject secret in secrets)
        {
            if (player.GetComponent<Collider2D>().IsTouching(secret.GetComponent<Collider2D>()))
            {
                secret.GetComponent<TextFade>().RevealText();
            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Disable player movement when the button is clicked
        player.GetComponent<MoveParty>().StopMovement();

        // Call the Reveal method
        Reveal();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Enable player movement when the button is released
        player.GetComponent<MoveParty>().StartMovement();
    }
}