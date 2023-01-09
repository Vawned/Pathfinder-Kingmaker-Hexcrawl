using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class IconChange : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;

    public SpriteRenderer spriteRenderer; // reference to the sprite renderer component
    public Sprite[] sprites; // array of sprites to switch between
    private int spriteIndex; // counter variable to keep track of the current sprite index

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        //player.transform.localScale = new Vector3(2.5f, 2.5f, 1);

        spriteIndex = 0; // initialize the sprite index to 0
        spriteRenderer.sprite = sprites[spriteIndex]; // set the initial sprite
    }

    // This function is called when the button is clicked
    public void ChangeSprite()
    {
        spriteIndex++; // increment the sprite index
        if (spriteIndex >= sprites.Length) // if the index is out of bounds, set it back to 0
        {
            spriteIndex = 0;
        }
        spriteRenderer.sprite = sprites[spriteIndex]; // set the sprite to the current index
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
