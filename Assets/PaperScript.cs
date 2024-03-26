using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.PoseDetection;
using UnityEngine;

public class PaperScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Folder")
        {
            Destroy(this.gameObject);
        }
    }
}
