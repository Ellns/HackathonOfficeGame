using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Missions : MonoBehaviour
{
    public bool Mission1 = false;
    public bool Mission2 = false;
    public bool Mission3 = false;

    private void Update()
    {
        if (Mission1 == false && Mission2 == false && Mission3 == false)
        {
            Debug.Log("you loose");
        }

        if (Mission1 == true && Mission2 == false && Mission3 == false)
        {
            Debug.Log("you loose");
        }

        if (Mission1 == true && Mission2 == true && Mission3 == false)
        {
            Debug.Log("you loose");
        }

        if (Mission1 == true && Mission2 == true && Mission3 == true)
        {
            Debug.Log("you win");
        }
    }
}
