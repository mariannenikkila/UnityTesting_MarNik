using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovikoodi1 : MonoBehaviour
{
    
    void Start()
    {
        
    }// Start

    
    void Update()
    {
        //O -n�pp�in aukaisee oven
        if (Input.GetKeyDown(KeyCode.O)) 
        {
            this.GetComponent<Animator>().SetInteger("ovitila1", 1);
        }//If
        //K -n�pp�in aukaisee oven
        if (Input.GetKeyDown(KeyCode.K))
        {
            this.GetComponent<Animator>().SetInteger("ovitila1", 0);
        }//If
    }// Update
}// Class
