using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookQueue : MonoBehaviour
{
    private int currentBook = 0;

    internal void BookAdd()
    {
        currentBook++;
    }
}
