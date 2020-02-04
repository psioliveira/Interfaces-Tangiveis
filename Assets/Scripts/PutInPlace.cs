using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutInPlace : MonoBehaviour
{
    public BookQueue queue;

    private void Start()
    {
        queue = GameObject.FindGameObjectWithTag("Book_Queue").GetComponent<BookQueue>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            queue.BookAdd();
        }
    }
}
