using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public Player player;
    public MovingBoss Boss;
    public GameObject Gobject;

    void Start()
    {
        player = GameObject.Find("TemporaryPlayer").GetComponent<Player>();
        Boss = GameObject.Find("Boss").GetComponent<MovingBoss>();

    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Boss")
        {
            print(player.Status);
        }
    }

    void Update()
    {
        
    }
}
