using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSoundTrigger : MonoBehaviour
{
    // Reference to the AudioSource component
    public AudioSource audioSource;

    // Sound to play when the player enters the collider
    public AudioClip triggerSound;

    // Set to true to play the sound only once
    private bool hasTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider is tagged as "Paper"
        if (other.CompareTag("Paper") && !hasTriggered)
        {
            // Play sound
            if (audioSource != null && triggerSound != null)
            {
                audioSource.PlayOneShot(triggerSound);
            }

            // Set the trigger flag to true to prevent multiple triggers
            hasTriggered = true;
        }
    }
}
