using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealSecret : MonoBehaviour
{
    public GameObject text;
    public GameObject player;

    public bool playerHere;

    private void Start() 
    {
        player = GameObject.FindWithTag("Player");
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            playerHere = true;
            // text.SetActive(true);
            // StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        text.SetActive(false);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            playerHere = false;            
        }
    }
}
