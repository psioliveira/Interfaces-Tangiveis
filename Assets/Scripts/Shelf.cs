using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    BookCounter book;
    [SerializeField]
    GameObject buttonUI;

    private void Start()
    {
        book = GameObject.FindGameObjectWithTag("Book_Handler").GetComponent<BookCounter>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (book.Check())
            {
                other.GetComponent<PlayerMovement>().CanInteract(true);
                buttonUI.SetActive(true);
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            buttonUI.SetActive(false);
            other.GetComponent<PlayerMovement>().CanInteract(false);
        }
       
    }
}
