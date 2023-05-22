using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanuunaTahtaaminen : MonoBehaviour
{
    //T‰h‰n haetaan lintuKuula
    public GameObject kuula = null;
    //T‰h‰n haetaan t‰ht‰in
    private GameObject tahtain = null;
    //Kanuunan kulma
    private float kulma = 0f;
    private float kulma2 = 0f;
    //Voima jolla kuulaa ammutaan
    private float kuulavoima = 7000f;
    
    void Start()
    {
        this.tahtain = GameObject.Find("tahtain");
        
    }// Start

    
    void Update()
    {
        //Asetaan kanuunan kulma ja s‰‰dell‰‰n sit‰ nuolin‰pp‰imill‰
        this.kulma = this.GetComponent<Transform>().rotation.eulerAngles.z;
        this.kulma2 = tahtain.GetComponent<Transform>().rotation.eulerAngles.z;

        if (Input.GetKey(KeyCode.LeftArrow) && (this.kulma < 75f))
        { 
            this.GetComponent<Transform>().Rotate(0f, 0f, 15f * Time.deltaTime);
            Debug.Log(this.kulma2);
        }//If

        if (Input.GetKey(KeyCode.RightArrow) && (this.kulma > 5f))
        { 
            this.GetComponent<Transform>().Rotate(0f, 0f, -15f * Time.deltaTime);
            Debug.Log(this.kulma2);
        }//If

        //Ammutaan vasemmalla Ctrl -n‰pp‰imell‰
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //Luodaan kuula piipun suulle
            GameObject apu = Instantiate(this.kuula, this.tahtain.GetComponent<Transform>().position, this.tahtain.GetComponent<Transform>().rotation);

            //Lasketaan kulmaa vastaava X- ja Y-suuntainen kerroin (0-1)
            float radkulma = this.kulma * Mathf.Deg2Rad;
            float x1 = Mathf.Cos(radkulma);
            float y1 = Mathf.Sin(radkulma);

            //Kerrotaan kulmakertoimet halutulla voimalla
            apu.GetComponent<Rigidbody2D>().AddForce(new Vector2(x1, y1) * this.kuulavoima);
            Destroy(apu.gameObject, 10f);
        }//If
    }// Update
}// Class
