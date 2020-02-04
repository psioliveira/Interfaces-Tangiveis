using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Question_Creator : MonoBehaviour
{
    [SerializeField]
    GameObject graphStuff;

    [SerializeField]
    GameObject GraphCreator;

    [SerializeField]
    GameObject QuestionAndAnswer;

    [SerializeField]
    GameObject Congrats;

    [SerializeField]
    private Graph_Manager creator;

    private int correctAnswer;

    [SerializeField]
    TextMeshProUGUI question;

    [SerializeField]
    TextMeshProUGUI answer1;
    [SerializeField]
    TextMeshProUGUI answer2;
    [SerializeField]
    TextMeshProUGUI answer3;
    [SerializeField]
    TextMeshProUGUI answer4;

    internal void CreateQuestion(Graph_Values graphToCreate)
    {
        //GraphCreator.GetComponent<Graph_Manager>().CreateGraph(graphToCreate);

        question.text = graphToCreate.Question;

        answer1.text = "A) " + graphToCreate.Answer1;
        answer2.text = "B) " + graphToCreate.Answer2;
        answer3.text = "C) " + graphToCreate.Answer3;
        answer4.text = "D) " + graphToCreate.Answer4;

        correctAnswer = graphToCreate.correctAnswer;
    }

    public void CheckAnswer(int test)
    {
        if(correctAnswer == test)
        {
            Youdidit();
        }
    }

    private void Youdidit()
    {
        graphStuff.SetActive(true);
        QuestionAndAnswer.SetActive(false);
    }
}
