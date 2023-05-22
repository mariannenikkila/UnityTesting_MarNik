using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LintuKoodi : MonoBehaviour
{
    //T‰ll‰ s‰‰det‰‰n linnun nopeus
    private float nopeus = 3f;
    private int suunta = 1;

    void Update()
    {
        //K‰‰nnyt‰‰n nuolin‰pp‰imill‰
        if (Input.GetKeyDown(KeyCode.RightArrow) && (this.suunta !=1)) {
            //K‰‰nnet‰‰n lintua ymp‰ri ja p‰ivitet‰‰n suunta
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
            this.suunta = 1;
            Debug.Log(this.suunta);
        }//If

        if (Input.GetKeyDown(KeyCode.LeftArrow) && (this.suunta != 2))
        {
            //K‰‰nnet‰‰n lintua ymp‰ri ja p‰ivitet‰‰n suunta
            this.GetComponent<Transform>().Rotate(0f,180f,0f);
            this.suunta = 2;
            Debug.Log(this.suunta);
        }//If

        //Liikutetaan lintua
        this.GetComponent<Transform>().Translate(this.nopeus * Time.deltaTime, 0f, 0f);
        
        if ((this.GetComponent<Transform>().position.x < -10f) ||
        this.GetComponent<Transform>().position.x > 10f)
        {
            this.GetComponent<Transform>().Rotate(0f, 180f, 0f);
        }
    }// Update
} //Class
