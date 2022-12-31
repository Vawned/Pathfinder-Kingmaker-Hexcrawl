using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drelev : MonoBehaviour
{

    public PolygonCollider2D[] childColliders;
    public GameObject player;

    public bool onDR;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        childColliders = GetComponentsInChildren<PolygonCollider2D>();
    }

    private void Update()
    {
        onDR = false;
        foreach (PolygonCollider2D collider in childColliders)
        {
            if (player.GetComponent<Collider2D>().IsTouching(collider))
            {
                onDR = true;
                break;
            }
        }
    }
}