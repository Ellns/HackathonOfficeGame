using System.Collections;
using System.Collections.Generic;
using Meta.WitAi.Windows;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void ExitButton()
    {

        Application.Quit();

    }
}
