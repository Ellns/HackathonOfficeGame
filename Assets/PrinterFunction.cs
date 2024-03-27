using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PrinterFunction : MonoBehaviour
{
    
    public GameObject yellowButton;
    public GameObject redButton;
    public GameObject greenButton;

    public bool yellowPress = false;
    public bool redPress = false;
    public bool greenPress = false;
    public GameObject paper;
    [SerializeField] private Transform destination;

    

    public void yellowButtonPressed()
    {
        yellowPress = true;
        Missions.missions.playing = false;
        complete();
    }

    public void redButtonPressed()
    {
        redPress = true;
        Missions.missions.playing = false;
        complete();
    }

    public void greenButtonPressed()
    {
        greenPress = true;
        Missions.missions.playing = false;
        complete();
    }

    private void complete()
    {
        if (Missions.missions.Keyboard == true && yellowPress == true && redPress == true && greenPress == true)
        {
            Missions.missions.Printer = true;
            Missions.missions.workPoints++;
            Missions.missions.updatePoints();
            Debug.Log("it works");
            spawn();
            KeyBoardFunction.keyboard.keysPressed = 0f;
            yellowPress = false;
            redPress = false;
            greenPress = false;
        }

    }

    private void spawn()
    {
        Instantiate(paper, destination);
        Debug.Log("paper spawned");
        
    }
}
