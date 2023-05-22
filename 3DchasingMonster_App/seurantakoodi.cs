using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Tämä tarvitaan AI:ta varten
using UnityEngine.AI;

public class seurantakoodi : MonoBehaviour
{
    //Tähän raahataan navigoinnin kohde
    public GameObject kohde = null;
    //Tämä koodi liitetään aina navigoivaan objektiin
    void Update()
    {
        //Laitetaan objekti hakeutumaan kohteeseen
        //Kohde voi olla myös liikkuva

        this.GetComponent<NavMeshAgent>().SetDestination(this.kohde.GetComponent<Transform>().position);
    }// Update
}// Class
