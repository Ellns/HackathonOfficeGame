using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Status;

    void Start()
    {
        SwitchStatus("Work");
    }
    void SwitchStatus(string status)
    {
        Status = status;
    }

    void Update()
    {
        
    }
}
