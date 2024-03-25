using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float speed = 5f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;
        if(BirdGameManager.manager.DestroyWall == true)
        {
            Destroy(this.gameObject);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
      
       
        if (other.tag == "BackWall")
        {
            Destroy(this.gameObject);

        }
    }
}
