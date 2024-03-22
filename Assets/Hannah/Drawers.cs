using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerMovement : MonoBehaviour
{
    // Define the start and end positions for drawer movement
    public Vector3 startPosition = new Vector3(24.28f, 0f, -39.04f);
    public Vector3 endPosition = new Vector3(18.67f, 0f, -39.04f);

    // Reference to the drawer GameObject
    public GameObject drawer;

    // Update is called once per frame
    void Update()
    {
        // Get input for drawer movement (e.g., from player input or animation)
        float input = Input.GetAxis("Horizontal"); // Adjust as needed based on input method

        // Calculate target position based on input
        Vector3 targetPosition = drawer.transform.position + Vector3.right * input;

        // Clamp target position within defined bounds
        targetPosition.x = Mathf.Clamp(targetPosition.x, Mathf.Min(startPosition.x, endPosition.x), Mathf.Max(startPosition.x, endPosition.x));

        // Apply movement to drawer
        drawer.transform.position = targetPosition;
    }
}
