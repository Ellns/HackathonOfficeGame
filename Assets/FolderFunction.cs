using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderFunction : MonoBehaviour
{
    public int workPoints;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "paper")
        {
            Missions.missions.Printer = false;
            Missions.missions.Folder = false;
            Missions.missions.Keyboard = false;
            workPoints += 1;
            Missions.missions.updatePoints();
            Debug.Log("it works");
            Missions.missions.playing = false;


        }
    }
}
