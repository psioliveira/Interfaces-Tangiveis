using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutInPlace : MonoBehaviour
{
    private BookCounter queue;
    private bool caught = false;

    private void Start()
    {
        queue = GameObject.FindGameObjectWithTag("Book_Handler").GetComponent<BookCounter>();
        queue.MoreBooks();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            caught = true;
            queue.CatchBook();
            Destroy(gameObject);
        }
    }

    private void OnDisable()
    {
        if (!caught)
        {
            queue.RemoveBook();
        }
    }
}
