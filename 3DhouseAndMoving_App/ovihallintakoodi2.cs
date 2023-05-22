using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovihallintakoodi2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {   //Etsit‰‰n ovi ja avataan jos pelaaja
        if (other.name.Equals("Pelaaja"))
        {
            GameObject.Find("ovi2_vasen").GetComponent<Animator>().SetInteger("ovitila2", 1);
            GameObject.Find("ovi2_oikea").GetComponent<Animator>().SetInteger("ovitila2", 1);
        }
    }//OnTriggerEnter

    private void OnTriggerExit(Collider other)
    {   //Etsit‰‰n ovi ja suljetaan jos pelaaja
        if (other.name.Equals("Pelaaja"))
        {
            GameObject.Find("ovi2_vasen").GetComponent<Animator>().SetInteger("ovitila2", 0);
            GameObject.Find("ovi2_oikea").GetComponent<Animator>().SetInteger("ovitila2", 0);
        }
    }//OnTriggerEnter
}// Class
