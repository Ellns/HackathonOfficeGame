using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardFunction : MonoBehaviour
{
    public int workPoints;
    

    private void OnTriggerEnter(Collider other)
    {
        if (Missions.missions.Printer == false && Missions.missions.Folder == false)
        {
            Missions.missions.Keyboard = true;
            workPoints += 1;
        }

    }

}
