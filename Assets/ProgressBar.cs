using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Video Tutorial https://www.youtube.com/watch?v=J1ng1zA3-Pk

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{
    public int minimum;
    public int maximum;
    public int current;
    public Image mask;
    float changePerSecond;
    public float timeToChange = 60;


    // Start is called before the first frame update
    public void Start()
    {
       
            changePerSecond = (minimum - maximum) / timeToChange;
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill ();


        if (current <= 0)
        {
            SceneManager.LoadScene("Main Menu");
            Debug.Log("you loose");

        }


    }

    
    void GetCurrentFill ()
    {
        float currentOffset = current - minimum;
        float maximumOffset = maximum - minimum;
        float fillAmount = currentOffset / maximumOffset;
        mask.fillAmount = fillAmount;
    }

    

}
