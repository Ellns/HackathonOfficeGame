using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn: MonoBehaviour
{

    public GameObject Crumble;

    public void SpawnPaper()
    {
        Instantiate(Crumble);
    }



}
