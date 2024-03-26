using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Video Tutorial https://www.youtube.com/watch?v=J1ng1zA3-Pk

[ExecuteInEditMode()]
public class ProgressBar1 : MonoBehaviour
{
    public float minimum;
    public float maximum;
    public float current;
    public Image mask;
    
    


    // Start is called before the first frame update
    public void Start()
    {
            
            
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill ();


        if (current <= 0)
        {
           
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
