using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutInPlace : MonoBehaviour
{
    public GameObject inPlace;


    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            this.gameObject.SetActive(false);
            inPlace.SetActive(true);
        }
    }
}
