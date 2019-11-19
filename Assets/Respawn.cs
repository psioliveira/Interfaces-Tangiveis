using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject spawn;
    public GameObject player;


    void OnTriggerEnter(Collider col)
    {
        Debug.Log("step1");
        if(col.tag == "Player")
        {
            Destroy(col.gameObject);
            Instantiate(player);
            Debug.Log("step2");
        }

        
    }
}
