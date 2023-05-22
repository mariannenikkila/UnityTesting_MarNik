using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovihallintakoodi1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {   //Etsit‰‰n ovi ja avataan jos pelaaja
        if (other.name.Equals("Pelaaja"))
        {
            GameObject.Find("ovi1").GetComponent<Animator>().SetInteger("ovitila1", 1);
        }
    }//OnTriggerEnter

    private void OnTriggerExit(Collider other)
    {   //Etsit‰‰n ovi ja suljetaan jos pelaaja
        if (other.name.Equals("Pelaaja"))
        {
            GameObject.Find("ovi1").GetComponent<Animator>().SetInteger("ovitila1", 0);
        }
    }//OnTriggerEnter
}// Class
