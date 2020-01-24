using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Question : MonoBehaviour
{
    [SerializeField]
    UI_Input_Manager PauseMenu;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PauseMenu.gameObject.SetActive(true);
            PauseMenu.MakeQuestion();
        }
    }
}
