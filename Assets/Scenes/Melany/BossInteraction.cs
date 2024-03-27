using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossInteraction : MonoBehaviour
{
    public Missions player;
    public GameObject Gobject;

    void Start()
    {
        player = GameObject.Find("Missions").GetComponent<Missions>();

    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        
    }
    void checkPlayerStatus()
    {
        print(player.playing);
    }

    void Update()
    {

    }
}
