using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPaper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
      if (other.tag == "ground")
      {
        Destroy(this.gameObject);
      }
    }



}
