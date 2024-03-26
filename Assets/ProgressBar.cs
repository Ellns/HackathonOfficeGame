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
    public float minimum = 0;
    public float maximum = 60;
    public float current;
    public Image mask;
    public float changePerSecond = -1;
    


    // Start is called before the first frame update
    public void Start()
    {
       
           
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill ();

        current = Mathf.Clamp(current + changePerSecond * Time.deltaTime, minimum, maximum);


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
