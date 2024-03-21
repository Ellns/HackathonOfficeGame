using UnityEngine;

public class PlayParticleOnTriggerEnter : MonoBehaviour
{
    public ParticleSystem particleSystem; // Assign your particle system in the inspector

    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has a Rigidbody component
        if (other.GetComponent<Rigidbody>() != null)
        {
            PlayParticles(other.transform.position);
        }
    }

    void PlayParticles(Vector3 position)
    {
        if (particleSystem != null)
        {
       //     particleSystem.transform.position = position; // Set particle system position to collision point
            particleSystem.Play(); // Play the particle system
        }
    }
}
