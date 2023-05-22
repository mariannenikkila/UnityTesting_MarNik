using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class koodi1 : MonoBehaviour
{
    //T‰ss‰ yll‰pidet‰‰n laskuria
    private float laskuri = 0f;

    //T‰h‰n haetaan teksti elementti
    private GameObject teksti = null;

    void Start()
    {
        //Haetaan tekstiobjekti
        this.teksti = GameObject.Find("teksti1");
    }// Start


    void Update()
    {
        //Kasvatetaan laskuria
        this.laskuri = this.laskuri + Time.deltaTime;



        if (this.laskuri < 15f)
        {        
            //Tulostetaan laskuri konsoliin
            Debug.Log("Laskuri:" + this.laskuri);

            //Tulostetaan laskuri teksti elementtiin
            this.teksti.GetComponent<TextMesh>().text = "LASKURI: " + this.laskuri;

            //Pyˆritet‰‰n laatikkoa
            this.GetComponent<Transform>().Rotate(15f * Time.deltaTime, 25f * Time.deltaTime, 35f * Time.deltaTime);
        } else
        {
            //Kytket‰‰n painovoima p‰‰lle
            this.GetComponent<Rigidbody>().isKinematic = false;
            Debug.Log("PUTOAA!!!");
            //Tulostetaan PUTOAA-teksti teksti elementtiin
            this.teksti.GetComponent<TextMesh>().color = Color.blue;
            this.teksti.GetComponent<TextMesh>().text = "PUTOAA!!!";
        }
        

    }// Update
} // Class
