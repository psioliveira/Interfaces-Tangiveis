using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BookCounter : MonoBehaviour
{
    int currentCount = 0;
    int maxBooks = 0;

    [SerializeField]
    GameObject prefab;

    [SerializeField]
    Transform count, maxCount;

    [SerializeField]
    TextMeshProUGUI countText, maxText;

    private void Start()
    {
        maxText.text = maxBooks.ToString();
        countText.text = currentCount.ToString();
    }

    internal void MoreBooks()
    {
        maxBooks++;
        Instantiate(prefab, maxCount);
        maxText.text = maxBooks.ToString();
        countText.text = currentCount.ToString();
    }

    internal void CatchBook()
    {
        currentCount++;
        Instantiate(prefab, count);
        countText.text = currentCount.ToString();
        maxText.text = maxBooks.ToString();
    }

    internal bool Check()
    {
        if(currentCount == maxBooks)
        {
            return true;
        }
        return false;
    }


}
