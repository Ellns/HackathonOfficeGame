using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardFunction : MonoBehaviour
{
    public int workPoints;
    public float keysPressed = 0f;


    private void OnTriggerExit(Collider other)
    {

        keysPressed++;

       

    }

    public void completion()
    {
        if(keysPressed == 20 && Missions.missions.Printer == false && Missions.missions.Folder == false)
        {
           Missions.missions.Keyboard = true;
            workPoints += 1;
            Missions.missions.updatePoints();
        }
    }
  

}
