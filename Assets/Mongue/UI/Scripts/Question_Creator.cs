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
    GameObject uiButton;

    [SerializeField]
    Animator me;

    [SerializeField]
    GameObject QuestionAndAnswer;


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

    [SerializeField]
    TextMeshProUGUI goodAnswer;

    [SerializeField]
    LevelHandler myHandler;

    [SerializeField]
    GameObject wrong, right;



    private void Start()
    {
        me = GetComponent<Animator>();
    }

    internal void CreateQuestion(Graph_Values graphToCreate)
    {
        GraphCreator.GetComponent<Graph_Manager>().CreateGraph(graphToCreate);
        question.text = graphToCreate.Question;

        answer1.text = "A) " + graphToCreate.Answer1;
        answer2.text = "B) " + graphToCreate.Answer2;
        answer3.text = "C) " + graphToCreate.Answer3;
        answer4.text = "D) " + graphToCreate.Answer4;
        goodAnswer.text = graphToCreate.correctAnswer.ToString();
        switch(graphToCreate.correctAnswer)
        {
            case 0:
                goodAnswer.text = "A) " + graphToCreate.Answer1;
                break;
            case 1:
                goodAnswer.text = "B)" + graphToCreate.Answer2;
                break;
            case 2:
                goodAnswer.text = "C)" + graphToCreate.Answer3;
                break;
            case 3:
                goodAnswer.text = "D)" + graphToCreate.Answer4;
                break;
        }

        correctAnswer = graphToCreate.correctAnswer;

    }

    private void RemoveButtons()
    {
        wrong.SetActive(false);
        right.SetActive(false);
    }

    private void ActivateButtons()
    {
        wrong.SetActive(true);
        right.SetActive(true);
    }

    public void CheckAnswer(int test)
    {
        Debug.Log("HELP ME");
        if(correctAnswer == test)
        {
            YouDidIt();
            
        }
        else
        {
            YouWrong();
        }
    }

    public void Go()
    {
        me.ResetTrigger("HideGood");
        me.ResetTrigger("Wrong");
        me.ResetTrigger("HideBad");
        me.ResetTrigger("Restart");
        me.ResetTrigger("Correct");
        me.SetTrigger("Go");
        uiButton.SetActive(false);
    }

    public void YouDidIt()
    {
        me.ResetTrigger("Go");
        me.ResetTrigger("HideGood");
        me.ResetTrigger("Wrong");
        me.ResetTrigger("HideBad");
        me.ResetTrigger("Restart");
        me.SetTrigger("Correct");
        ActivateButtons();
    }

    public void YouDidItConfirm()
    {
        me.ResetTrigger("Go");
        me.ResetTrigger("Correct");
        me.ResetTrigger("Wrong");
        me.ResetTrigger("HideBad");
        me.ResetTrigger("Restart");
        me.SetTrigger("HideGood");
        myHandler.CorrectAnswer();
        RemoveButtons();
    }

    public void YouWrong()
    {
        me.ResetTrigger("Go");
        me.ResetTrigger("Correct");
        me.ResetTrigger("HideGood");
        me.ResetTrigger("HideBad");
        me.ResetTrigger("Restart");
        me.SetTrigger("Wrong");
        ActivateButtons();
    }

    public void YouWrongConfirm()
    {
        me.ResetTrigger("Go");
        me.ResetTrigger("Correct");
        me.ResetTrigger("HideGood");
        me.ResetTrigger("Wrong");
        me.ResetTrigger("Restart");
        me.SetTrigger("HideBad");
        myHandler.WrongAnswer();
        RemoveButtons();
    }

    public void Restart()
    {
        me.ResetTrigger("Go");
        me.ResetTrigger("Correct");
        me.ResetTrigger("HideGood");
        me.ResetTrigger("Wrong");
        me.ResetTrigger("HideBad");
        me.SetTrigger("Restart");
    }

}
