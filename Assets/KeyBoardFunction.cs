using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyBoardFunction : MonoBehaviour
{
    public int workPoints;
    public float keysPressed = 0f;
    public static KeyBoardFunction keyboard;
    public TextMeshProUGUI keynumber;

    private void OnTriggerExit(Collider other)
    {

        keysPressed++;
        keynumber.SetText(keysPressed.ToString());
        Debug.Log("you did it");
       

    }

    public void completion()
    {
        if(keysPressed == 20 && Missions.missions.Printer == false && Missions.missions.Folder == false)
        {
           Missions.missions.Keyboard = true;
            workPoints += 1;
            Missions.missions.updatePoints();
            Debug.Log("you worked");
            
        }
    }

  

}
