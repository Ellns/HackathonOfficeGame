using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public GameObject birdObject;
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;
    public bool losestate = false;
    public Rigidbody birdRigid => birdObject.GetComponent<Rigidbody>();
   

    // Start is called before the first frame update
    void Start()
    {
        if(birdRigid == null)
        {
            Debug.Log("rigid is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction = Vector3.up * strength;
          


            
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            BirdGameManager.manager.GameLose();
            BirdGameManager.manager.isAlive = false;
            ToggleGravity();
        }

        if (other.tag == "score")
        {
            BirdGameManager.manager.IncrementScore();
        }
    }

   public void ToggleGravity()
    {
        birdRigid.useGravity = !birdRigid.useGravity;
    }

    public void ResetPosition()
    {
        birdObject.transform.position = BirdGameManager.manager.respawn.transform.position;
    }

}
