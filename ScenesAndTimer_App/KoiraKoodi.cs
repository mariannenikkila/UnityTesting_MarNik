using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoiraKoodi : MonoBehaviour
{   
    //T‰ll‰ s‰‰det‰‰n koiran nopeus
    private float nopeus = 5f;
    
    void Start()
    {
        
    }// Start

    void Update()
    {
        //Koira liikkuu positiivisen X-akselin suuntaan
        this.GetComponent<Transform>().Translate(this.nopeus * Time.deltaTime, 0f, 0f);

        //K‰‰nnet‰‰n koira p‰‰dyss‰ vastakkaiseen suuntaan
        if ((this.GetComponent<Transform>().position.x < -10f) ||
            this.GetComponent<Transform>().position.x > 10f)
        {
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
        }// If
    }// Update
}
