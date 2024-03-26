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
