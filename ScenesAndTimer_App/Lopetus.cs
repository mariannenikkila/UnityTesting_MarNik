using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lopetus : MonoBehaviour
{
    //T‰ss‰ yll‰pidet‰‰n laskuria
    private float laskuri = 0f;
    private float laskuri2 = 15f;
    //T‰h‰n haetaan teksti elementti
    private GameObject teksti = null;
    private GameObject tekstit = null;

    void Start()
    {
        //Haetaan tekstiobjekti
        this.teksti = GameObject.Find("T1");

    }// Start


    void Update()
    {
        //Kasvatetaan laskuria
        this.laskuri = this.laskuri + Time.deltaTime;



        if (this.laskuri < 15f)
        {
            
            //Tulostetaan laskuri teksti elementtiin
            this.teksti.GetComponent<Text>().text = "Peli loppuu " + ((int)this.laskuri2 - this.laskuri) + "kuluttua.";
            Debug.Log(this.laskuri);
        }
        else
        {
            SceneManager.LoadScene("gameoverskene");
        }


    }// Update
} // Class
