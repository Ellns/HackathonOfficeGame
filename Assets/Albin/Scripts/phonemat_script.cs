using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phonemat_script : MonoBehaviour
{
    public Material phone;
    public Camera pcamera;
    // Start is called before the first frame update
    void Start()
    {
        phone.mainTextureScale = new Vector2(pcamera.rect.width, pcamera.rect.height);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
