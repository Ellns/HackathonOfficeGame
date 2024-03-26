using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using UnityEngine.SceneManagement;

public class Missions : MonoBehaviour
{
    public bool Keyboard = false;
    public bool Printer = false;
    public bool Folder = false;
    public float happiness = 100f;
    public static Missions missions;
    public int workPoints = 0;
    public TextMeshProUGUI workPointsUI;

    private void Start()
    {
        updatePoints();
    }
    private void Update()
    {
        if (Keyboard == false && Printer == false && Folder == false)
        {
            Debug.Log("you loose");
        }

        if (Keyboard == true && Printer == false && Folder == false)
        {
            Debug.Log("keyboard works");
        }

        if (Keyboard == true && Printer == true && Folder == false)
        {
            Debug.Log("printer works");
        }

        if (Keyboard == true && Printer == true && Folder == true)
        {
            Debug.Log("you win and everything works");
        }
    }

    public void updatePoints()
    {
        workPointsUI.SetText(workPoints.ToString());
    }

    public void jobDone()
    {

        if(workPoints == 9)
        {
            SceneManager.LoadScene(0);
            Debug.Log("you win");
        }
    }


}
