using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    [SerializeField]
    private float zoomStep, minCamSize, maxCamSize;

    [SerializeField]
    private SpriteRenderer mapRenderer;

    private float mapMinX, mapMaxX, mapMinY, mapMaxY;

    private Vector3 dragOrigin;

    public float smoothSpeed;

    public Transform target;

    public Vector3 offset;

    public float zoomSpeed = 0.1f; // Adjust this value to control the speed of the zoom
    public float zoomStart = 4; // The starting value for the zoom
    public float zoomEnd = 13; // The ending value for the zoom
    public float zoomTime = 0.5f; // The current time it takes to zoom

    private void Awake() 
    {
        Cursor.visible = false;
        mapMinX = mapRenderer.transform.position.x - mapRenderer.bounds.size.x / 2f;
        mapMaxX = mapRenderer.transform.position.x + mapRenderer.bounds.size.x / 2f;

        mapMinY = mapRenderer.transform.position.y - mapRenderer.bounds.size.y / 2f;
        mapMaxY = mapRenderer.transform.position.y + mapRenderer.bounds.size.y / 2f;
    }

    private void Update() 
    {
        PanCamera();

       // Increment the zoom time
        zoomTime += Time.deltaTime;

        // Use Lerp to smoothly interpolate between the starting and ending values for the zoom
        cam.orthographicSize = Mathf.Lerp(zoomStart, zoomEnd, zoomTime * zoomSpeed);

        // Clamp the camera size to the min and max values
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minCamSize, maxCamSize);

        if (Input.GetAxis("Mouse ScrollWheel") > 0f ) // In
        {
            ZoomIn();
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f ) // Out
        {
            ZoomOut();
        }
    }

    private void FixedUpdate() 
    {
        Vector3 desiredPosition = target.position + offset;
        
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        cam.transform.position = ClampCamera(cam.transform.position);

    }

    private void PanCamera()
    {
        if (Input.GetMouseButtonDown(2))
        {
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButton(2))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);
            cam.transform.position = ClampCamera(cam.transform.position += difference);

            //cam.transform.position += difference;
        }
    }

    public void ZoomIn()
    {
        // Set the starting and ending values for the zoom
        zoomStart = cam.orthographicSize;
        zoomEnd = cam.orthographicSize - zoomStep;

        // Reset the zoom time
        zoomTime = 0;
    }

    public void ZoomOut()
    {
        // Set the starting and ending values for the zoom
        zoomStart = cam.orthographicSize;
        zoomEnd = cam.orthographicSize + zoomStep;

        // Reset the zoom time
        zoomTime = 0;
    }
    // public void ZoomIn()
    // {
    //     float newSize = cam.orthographicSize - zoomStep;
    //     cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

    //     cam.transform.position = ClampCamera(cam.transform.position);
    // }
    // public void ZoomOut()
    // {
    //     float newSize = cam.orthographicSize + zoomStep;
    //     cam.orthographicSize = Mathf.Clamp(newSize, minCamSize, maxCamSize);

    //     cam.transform.position = ClampCamera(cam.transform.position);
    // }

    private Vector3 ClampCamera(Vector3 targetPosition)
    {
        float camHeight = cam.orthographicSize;
        float camWidth = cam.orthographicSize * cam.aspect;

        float minX = mapMinX + camWidth;
        float maxX = mapMaxX - camWidth;
        float minY = mapMinY + camHeight;
        float maxY = mapMaxY - camHeight;

        float newX = Mathf.Clamp(targetPosition.x, minX, maxX);
        float newY = Mathf.Clamp(targetPosition.y, minY, maxY);


        return new Vector3(newX, newY, -10);
    }
}