using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ToggleButtonScript : MonoBehaviour
{
    public Button button; // reference to the button
    public Sprite originalImage; // reference to the original image of the button
    public Sprite newImage; // reference to the new image that will be displayed when the button is clicked

    private bool isClicked = false; // flag to track whether the button is clicked or not

    void Start()
    {
        // Add a listener for the click event on the button
        button.onClick.AddListener(ToggleImage);
    }

    // This function will be called when the button is clicked
    void ToggleImage()
    {
        // If the button is not clicked, set the image to the new image and set the flag to true
        if (!isClicked)
        {
            button.GetComponent<Image>().sprite = newImage;
            isClicked = true;
        }
        // If the button is clicked, set the image to the original image and set the flag to false
        else
        {
            button.GetComponent<Image>().sprite = originalImage;
            isClicked = false;
        }
    }
}