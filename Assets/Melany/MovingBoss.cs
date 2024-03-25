using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBoss : MonoBehaviour
{ 
    
    public GameObject Boss;
    public GameObject WallStart;
    public GameObject WallEnd;
    public float speed;
    private GameObject GoTo;

    void Start()
    {
        GoTo = WallEnd;
    }

    void Update() {

        MoveBoss(GoTo);
    }
    void OnCollisionEnter( Collision collisionInfo) {
        print(collisionInfo.collider.name);
        if (collisionInfo.collider.name == "WallEnd") {
            GoTo = WallStart;
        }
        if (collisionInfo.collider.name == "WallStart")
        {
            GoTo = WallEnd;
        };
    }
    void MoveBoss(GameObject toWall)
    {
        Boss.transform.position = Vector3.MoveTowards(Boss.transform.position, toWall.transform.position, speed);
  }
}
