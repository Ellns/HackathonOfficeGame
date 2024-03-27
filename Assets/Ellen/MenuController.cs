using System.Collections;
using System.Collections.Generic;
//using Meta.WitAi.Windows;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

        public void StartButton()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void ExitButton()
        {

            Application.Quit();
        Debug.Log("Quit");

        }

    
}
