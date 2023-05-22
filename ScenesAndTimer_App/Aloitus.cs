using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Aloitus : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Destroy(this.gameObject);
        }//If
    }// Update
}
