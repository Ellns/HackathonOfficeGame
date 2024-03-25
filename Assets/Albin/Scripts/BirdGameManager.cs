using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdGameManager : MonoBehaviour
{
    public int score = 0;
    public Transform respawn;
    public GameObject bird;
    public static BirdGameManager manager;
    public Spawner spawner;
    public bool isAlive = true;
    public BirdScript birdScript;

    // Start is called before the first frame update
    void Awake()
    {
        birdScript = bird.GetComponent<BirdScript>();

        if(manager == null)
        {
            manager = this;
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();

        }
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("added score");
    }

    public void Restart()
    {
        
        score = 0;
        birdScript.ResetPosition();
        isAlive = true;
        birdScript.GravityStart = true;
        //birdScript.birdRigid.velocity = new Vector3(0, 0 ,0);
        birdScript.BirdJump();
        ToggleSpawner();


    }

    public void ToggleSpawner()
    {
        spawner.gameObject.SetActive(!spawner.gameObject.activeInHierarchy);
       
    }

    public void GameLose()
    {
        if (!isAlive) return;
        ToggleSpawner();
        birdScript.ToggleGravity();
    }
}
