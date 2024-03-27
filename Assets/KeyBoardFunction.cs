using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyBoardFunction : MonoBehaviour
{
    
    public float keysPressed = 0f;
    public static KeyBoardFunction keyboard;
    public TextMeshProUGUI keynumber;

    public void keyPress()
    {
        if(!Missions.missions.Keyboard) //if keyboard is false
        {
            keysPressed++;
            keynumber.SetText(keysPressed.ToString());
            Debug.Log("you did it");
            Missions.missions.playing = false;
            completion();
        }
        

    }

    public void completion()
    {
        if(keysPressed >= 20 && Missions.missions.Printer == false && Missions.missions.Folder == false)
        {
            Missions.missions.Keyboard = true;
            Missions.missions.workPoints += 1;
            Missions.missions.updatePoints();
            Debug.Log("you worked");
            keysPressed = 0;
            
        }
    }

  

}
