using System.Collections;
using System.Collections.Generic;
using Meta.WitAi.Windows;
using UnityEngine;

public class PrinterFunction : MonoBehaviour
{
    public int workPoints;
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
    }

    public void redButtonPressed()
    {
        redPress = true;
    }

    public void greenButtonPressed()
    {
        greenPress = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Missions.missions.Keyboard == true && Missions.missions.Folder == false && yellowPress == true && redPress == true && greenPress == true)
        {
            Missions.missions.Printer = true;
            workPoints += 1;
            Debug.Log("it works");
            spawn();
        }

    }

    private void spawn()
    {
        Instantiate(paper, destination);
        
    }
}
