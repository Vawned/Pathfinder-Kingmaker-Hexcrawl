using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Greenbelt : MonoBehaviour
{

    public PolygonCollider2D[] childColliders;
    public GameObject player;

    public bool onGB;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        childColliders = GetComponentsInChildren<PolygonCollider2D>();
    }

    private void Update()
    {
        onGB = false;
        foreach (PolygonCollider2D collider in childColliders)
        {
            if (player.GetComponent<Collider2D>().IsTouching(collider))
            {
                onGB = true;
                break;
            }
        }
    }
}