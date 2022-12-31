 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFade : MonoBehaviour
{
    public GameObject text;

    private void Start() 
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.tag == "Player")
        {
            if(gameObject.tag =="Secret")
            {
                return;
            }
            else
            {
                text.SetActive(true);
                StartCoroutine("WaitForSec");
            }
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        text.SetActive(false);
    }

    public void RevealText()
    {
        text.SetActive(true);
        StartCoroutine("WaitForSec");
    }
}
