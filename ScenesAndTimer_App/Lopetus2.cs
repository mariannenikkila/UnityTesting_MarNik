using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lopetus2 : MonoBehaviour
{


    void Update()
    {
        //ESC-n�pp�in sulkee sovelluksen
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Suljetaan sovellus
            Application.Quit();
        }
    }// Update 
}
