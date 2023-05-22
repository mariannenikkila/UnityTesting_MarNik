using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valokoodi1 : MonoBehaviour
{
  
    void Update()
    {
        //Lammpu palaa kun L-näppäintä painetaan
        if (Input.GetKeyDown(KeyCode.L)) 
        {
            this.GetComponent<Light>().enabled = true;
        }// If
         //Lammpu sammuu kun L-näppäin vapautetaan
        if (Input.GetKeyUp(KeyCode.L))
        {
            this.GetComponent<Light>().enabled = false;
        }// If
    }// Update
}// Class
