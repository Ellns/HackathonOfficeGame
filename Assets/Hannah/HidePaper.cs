using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePaper : MonoBehaviour
{
    private LayerMask destroyLayer; // Layer to check for objects to destroy

    private void Start()
    {
        // Set the layer to check for (e.g., "ThrowableObject")
        destroyLayer = LayerMask.GetMask("ThrowableObject");
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((destroyLayer & (1 << other.gameObject.layer)) != 0) // Check if colliding object is in the destroyLayer
        {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
