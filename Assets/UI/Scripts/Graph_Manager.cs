using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Graph_Manager : MonoBehaviour
{
    GameObject[] createdObj;

    float currentLocation;

    [SerializeField]
    GameObject startPrefab;
    [SerializeField]
    GameObject endPrefab;
    [SerializeField]
    GameObject inbetweenPrefab;

    [SerializeField]
    Sprite Empty;

    [SerializeField]
    Sprite QEnd;

    [SerializeField]
    Sprite QStart;

    [SerializeField]
    Sprite Start;

    [SerializeField]
    Sprite Neutral;

    [SerializeField]
    Sprite Q1;

    [SerializeField]
    Sprite Q_neutral;

    [SerializeField]
    Sprite Q_Med;

    [SerializeField]
    Sprite Q3;

    [SerializeField]
    Sprite End;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            CreateGraph(new Graph_Values(2, 20 ,4f, 8f, 15f));
        }
    }


    internal void CreateGraph(Graph_Values currentDataBase)
    {
        ClearChildren();

        GameObject child = Instantiate(startPrefab, transform);
        child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
        child.GetComponentInChildren<TextMeshProUGUI>().text = "0";
        // START CREATION.
        if (currentDataBase.lowestValue != 0)
        {
            child.GetComponent<Image>().sprite = Empty;
            CreateGraphFiller(currentDataBase.intervals, currentDataBase.intervals, currentDataBase.lowestValue, 3);
            child = Instantiate(inbetweenPrefab, transform);
            child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
            if (currentDataBase.Q1 == (int)currentDataBase.Q1)
            {
                child.GetComponentInChildren<TextMeshProUGUI>().text = currentDataBase.lowestValue.ToString();
            }
            child.GetComponent<Image>().sprite = Start;
        }
        else
        {
            child.GetComponent<Image>().sprite = QStart;
        }


        // FILLER TILL Q1
        if(currentDataBase.Q1 != currentDataBase.lowestValue)
        {
            CreateGraphFiller(currentDataBase.intervals, currentDataBase.intervals + currentDataBase.lowestValue, currentDataBase.Q1, 2);
            //Q1 Creation
            child = Instantiate(inbetweenPrefab, transform);
            child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
            if (currentDataBase.Q1 == (int)currentDataBase.Q1)
            {
                child.GetComponentInChildren<TextMeshProUGUI>().text = currentDataBase.Q1.ToString();
            }
            child.GetComponent<Image>().sprite = Q1;
        }
        else
        {
            child.GetComponent<Image>().sprite = QStart;
        }

        //Q1 FILLER TILL MEDIAN
        if (currentDataBase.Median != currentDataBase.Q1)
        {
            CreateGraphFiller(currentDataBase.intervals, currentDataBase.Q1 + 
                currentDataBase.intervals, currentDataBase.Median, 1);
            child = Instantiate(inbetweenPrefab, transform);
            child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
            if (currentDataBase.Median == (int)currentDataBase.Median)
            {
                child.GetComponentInChildren<TextMeshProUGUI>().text = currentDataBase.Median.ToString();
            }
            child.GetComponent<Image>().sprite = Q_Med;
        }
        else
        {
            // Nothing since we just skip this.
        }

        // Median till Q3

        if (currentDataBase.Q3 != currentDataBase.Median)
        {
            CreateGraphFiller(currentDataBase.intervals, currentDataBase.Median +
    currentDataBase.intervals, currentDataBase.Q3, 1);
            child = Instantiate(inbetweenPrefab, transform);
            child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
            if (currentDataBase.Q3 == (int)currentDataBase.Q3)
            {
                child.GetComponentInChildren<TextMeshProUGUI>().text = currentDataBase.Q3.ToString();
            }
            child.GetComponent<Image>().sprite = Q3;
        }
        else
        {
            child.GetComponent<Image>().sprite = Q3;
        }

        // Q3 until Highest Value
        if(currentDataBase.Q3 != currentDataBase.HighestValue)
        {
            CreateGraphFiller(currentDataBase.intervals, currentDataBase.Q3 +
                                        currentDataBase.intervals, currentDataBase.HighestValue, 2);
            child = Instantiate(inbetweenPrefab, transform);
            child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
             child.GetComponentInChildren<TextMeshProUGUI>().text = currentDataBase.HighestValue.ToString();
            child.GetComponent<Image>().sprite = End;
        }
        else
        {
            child.GetComponent<Image>().sprite = QEnd;
        }

        // Highest Value until 30
        if (currentDataBase.HighestValue != 30)
        {
            CreateGraphFiller(currentDataBase.intervals, currentDataBase.HighestValue +
                                        currentDataBase.intervals, 30, 3);
            child = Instantiate(inbetweenPrefab, transform);
            child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
            child.GetComponentInChildren<TextMeshProUGUI>().text = "30";
            child.GetComponent<Image>().sprite = Empty;
        }

        //// FILLER UNTIL Q1
        //for (float i = currentDataBase.intervals; i < currentDataBase.Q1;)
        //{
        //    child = Instantiate(inbetweenPrefab, transform);
        //    child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
        //    if(i == (int)i)
        //    {
        //        child.GetComponentInChildren<TextMeshProUGUI>().text = i.ToString();
        //    }
        //    i += 0.25f;
        //}
        // Q1 CREATION


        //// FILLER UNTIL MED.
        //for (float i = currentDataBase.intervals + currentDataBase.Q1; i < currentDataBase.Median;)
        //{
        //    child = Instantiate(inbetweenPrefab, transform);
        //    child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
        //    if (i == (int)i)
        //    {
        //        child.GetComponentInChildren<TextMeshProUGUI>().text = i.ToString();
        //    }
        //    i += 0.25f;
        //}

        //// MEDIAN CREATION
        //child = Instantiate(inbetweenPrefab, transform);
        //child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
        //if (currentDataBase.Median == (int)currentDataBase.Median)
        //{
        //    child.GetComponentInChildren<TextMeshProUGUI>().text = currentDataBase.Median.ToString();
        //}

        //// FILLER UNTIL Q3.
        //for (float i = currentDataBase.intervals + currentDataBase.Median; i < currentDataBase.Q3;)
        //{
        //    child = Instantiate(inbetweenPrefab, transform);
        //    child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
        //    if (i == (int)i)
        //    {
        //        child.GetComponentInChildren<TextMeshProUGUI>().text = i.ToString();
        //    }
        //    i += 0.25f;
        //}

        //// Q3 CREATION
        //child = Instantiate(inbetweenPrefab, transform);
        //child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals*40, 130);
        //if (currentDataBase.Q3 == (int)currentDataBase.Q3)
        //{
        //    child.GetComponentInChildren<TextMeshProUGUI>().text = currentDataBase.Q3.ToString();
        //}

        //// FILLER UNTIL END
        //for (float i = currentDataBase.intervals + currentDataBase.Q3; i < 30;)
        //{
        //    child = Instantiate(inbetweenPrefab, transform);
        //    child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
        //    if (i == (int)i)
        //    {
        //        child.GetComponentInChildren<TextMeshProUGUI>().text = i.ToString();
        //    }
        //    i += 0.25f;
        //}

        //// END CREATION

        //child = Instantiate(endPrefab, transform);
        //child.GetComponent<RectTransform>().sizeDelta = new Vector2(currentDataBase.intervals * 40, 130);
        //    child.GetComponentInChildren<TextMeshProUGUI>().text = "30";
    }

    /// <summary>
    /// 1 inquert, 2 if normal filler, 3 if empty.
    /// </summary>
    /// <param name="interval"></param>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="type"></param>
    private void CreateGraphFiller(float interval, float start, float end, int inquert)
    {
        Debug.Log(end);
        bool firstrun = true;
        for (float i = start; i < end;)
        {
            GameObject child = Instantiate(inbetweenPrefab, transform);
            child.GetComponent<RectTransform>().sizeDelta = new Vector2(interval * 40, 130);
            if (i == (int)i)
            {
                child.GetComponentInChildren<TextMeshProUGUI>().text = i.ToString();
            }
            if(inquert == 2)
            {
                child.GetComponent<Image>().sprite = Neutral;
            }
            else if(inquert == 1)
            {
                child.GetComponent<Image>().sprite = Q_neutral;
            }
            else if(inquert == 3)
            {
                child.GetComponent<Image>().sprite = Empty;
            }
            if(interval == start && inquert == 2 && firstrun)
            {
                firstrun = false;
                child.GetComponent<Image>().sprite = Start;
            }
            i += 0.25f;
        }
    }

    private void ClearChildren()
    {
        {
            foreach (Transform child in transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }
    }
}
