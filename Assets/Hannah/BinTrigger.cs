using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinTrigger : MonoBehaviour
{
    ParticleSystem glitter;

    // Start is called before the first frame update
    void Start()
    {
        glitter = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        glitter.Play();
        Missions.missions.happiness += 5f;
    }


}
