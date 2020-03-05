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

    Queue<GameObject> queue;

    private void Start()
    {
        queue = new Queue<GameObject>();
        maxText.text = maxBooks.ToString();
        countText.text = currentCount.ToString();
    }

    internal void MoreBooks()
    {
        maxBooks++;
        queue.Enqueue(Instantiate(prefab, maxCount));
        maxText.text = maxBooks.ToString();
        countText.text = currentCount.ToString();
    }

    internal void CatchBook()
    {
        currentCount++;
        queue.Enqueue(Instantiate(prefab, count));
        countText.text = currentCount.ToString();
        maxText.text = maxBooks.ToString();
    }

    internal void RemoveBook()
    {
        maxBooks--;
        Destroy(queue.Dequeue());
        maxText.text = maxBooks.ToString();
        countText.text = currentCount.ToString();
    }

    internal void ResetBook()
    {
        maxBooks = 0;
        currentCount = 0;
        maxText.text = maxBooks.ToString();
        countText.text = currentCount.ToString();
        foreach (GameObject temp in queue)
        {
            Destroy(temp);
        }
        queue.Clear();
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
