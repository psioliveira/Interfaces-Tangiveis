using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookQueue : MonoBehaviour
{
    [SerializeField]
    Animator[] Books;
    private int currentBook = 0;

    internal void BookAdd()
    {
        Books[currentBook].SetTrigger("Go");
        currentBook++;
    }
}
