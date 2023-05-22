using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//T�m� tarvitaan AI:ta varten
using UnityEngine.AI;

public class seurantakoodi : MonoBehaviour
{
    //T�h�n raahataan navigoinnin kohde
    public GameObject kohde = null;
    //T�m� koodi liitet��n aina navigoivaan objektiin
    void Update()
    {
        //Laitetaan objekti hakeutumaan kohteeseen
        //Kohde voi olla my�s liikkuva

        this.GetComponent<NavMeshAgent>().SetDestination(this.kohde.GetComponent<Transform>().position);
    }// Update
}// Class
