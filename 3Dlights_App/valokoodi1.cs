using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valokoodi1 : MonoBehaviour
{
  
    void Update()
    {
        //Lammpu palaa kun L-n�pp�int� painetaan
        if (Input.GetKeyDown(KeyCode.L)) 
        {
            this.GetComponent<Light>().enabled = true;
        }// If
         //Lammpu sammuu kun L-n�pp�in vapautetaan
        if (Input.GetKeyUp(KeyCode.L))
        {
            this.GetComponent<Light>().enabled = false;
        }// If
    }// Update
}// Class
