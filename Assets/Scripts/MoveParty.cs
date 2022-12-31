using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MoveParty : MonoBehaviour
{
    public float speed;
    private Vector3 target;

    public bool canMove = true;


    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                // Perform the raycast as before
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, LayerMask.GetMask("Hex Cells"));

                if (hit)
                {
                    // Calculate the position of the hit hex cell as before
                    GameObject hitHexCell = hit.collider.gameObject;
                    PolygonCollider2D hitHexCellCollider = hitHexCell.GetComponent<PolygonCollider2D>();
                    Vector3 hexCellPosition = hitHexCellCollider.bounds.center;

                    // Update the target position of the player icon
                    target = hexCellPosition;
                }
            }
            // Only move the player icon if it is not already at the target position
            if (transform.position != target)
            {
                GetComponent<Rigidbody2D>().MovePosition(Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime));
            }
        }
    }
    
    public void StopMovement()
    {
        canMove = false;
    }
    public void StartMovement()
    {
        canMove = true;
    }
}