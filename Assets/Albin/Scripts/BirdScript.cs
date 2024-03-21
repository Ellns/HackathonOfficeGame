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
    public int score = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction = Vector3.up * strength;
            Debug.Log("helloworld");
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            losestate = true;
            Debug.Log("you lose");
        }

        if (other.tag == "Score")
        {
            score += 1;
            Debug.Log("added score");
        }
    }

   


}
