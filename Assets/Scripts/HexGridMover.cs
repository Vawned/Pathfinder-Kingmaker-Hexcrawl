using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class HexGridMover : MonoBehaviour
{
    // An array of hex cell game objects.
    public GameObject[] hexCells;

    void Update()
    {
        // Check if the left mouse button is clicked.
        if (Input.GetMouseButtonDown(0))
        {
            // Create a ray from the mouse position.
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Set the layer mask to only detect objects on the "Hex Cells" layer.
            int layerMask = 1 << LayerMask.NameToLayer("Hex Cells");

            // Declare a variable to store the result of the raycast.
            RaycastHit hit;

            // Perform the raycast and store the result.
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                // The raycast hit an object on the "Hex Cells" layer.
                // Check if the object is a hex cell.
                GameObject hitObject = hit.collider.gameObject;
                if (hexCells.Contains(hitObject))
                {
                    // The hit object is a hex cell.
                    // Calculate the center position of the hex cell.
                    Vector3 centerPosition = CalculateHexCellCenterPosition(hitObject);

                    // Snap move the player icon to the center position of the hex cell.
                    transform.position = centerPosition;
                }
            }
        }
    }

    // Calculates the center position of a hex cell game object.
    public Vector3 CalculateHexCellCenterPosition(GameObject hexCell)
    {
        // Get the polygon collider of the hex cell.
        PolygonCollider2D collider = hexCell.GetComponent<PolygonCollider2D>();

        // Calculate the center position of the hex cell by averaging the positions of the collider's vertices.
        Vector3 centerPosition = Vector3.zero;
        for (int i = 0; i < collider.points.Length; i++)
        {
            centerPosition += (Vector3)collider.points[i];
        }
        centerPosition /= collider.points.Length;

        // Offset the center position to account for the hex cell's local position and rotation.
        centerPosition += hexCell.transform.localPosition;
        centerPosition = hexCell.transform.rotation * centerPosition;

        return centerPosition;
    }
}
