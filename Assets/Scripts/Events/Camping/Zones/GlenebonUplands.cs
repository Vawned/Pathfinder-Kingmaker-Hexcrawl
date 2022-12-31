using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlenebonUplands : MonoBehaviour
{

    public PolygonCollider2D[] childColliders;
    public GameObject player;

    public bool onGU;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        childColliders = GetComponentsInChildren<PolygonCollider2D>();
    }

    private void Update()
    {
        onGU = false;
        foreach (PolygonCollider2D collider in childColliders)
        {
            if (player.GetComponent<Collider2D>().IsTouching(collider))
            {
                onGU = true;
                break;
            }
        }
    }
}