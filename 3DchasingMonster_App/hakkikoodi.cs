using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hakkikoodi : MonoBehaviour
{
    
    void Start()
    {
        
    }// Start

    
    void Update()
    {
        
    }// Update

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("hakki")) 
        {
            other.GetComponent<Animator>().SetInteger("hakki2", 1);
        }// IF
    } //OnTriggerEnter
}// Class
