using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UI.Extensions.Examples;
using System.Linq;

public class UI_Input_Manager : MonoBehaviour
{
    [SerializeField]
    Graph_Manager currentGraphManager;

    [SerializeField]
    GameObject GraphCreator;

    [SerializeField]
    Animator UpdateAnim;

    [SerializeField]
    GameObject QuestionAndAnswer;

    GameObject graphcreated;

    int lowestValue = 1;
    int highestValue = 20;
    float quartil_1 = 5;
    float median = 8;
    float quartil_3 = 15;

    private string Question;
    private string Answer1;
    private string Answer2;
    private string Answer3;
    private string Answer4;
    private int correctAnswer = 0;

    private int currentNumber = 0;
    private List<Graph_Values> questionList;

    [SerializeField]
    private Example02ScrollView scrollView;

    [SerializeField]
    private TMP_InputField lowestValueText, highestValueText, quartil_1Text, medianText, quartil_3Text, QuestionText, Answer1Text, Answer2Text, Answer3Text, Answer4Text;
    [SerializeField]
    private TMP_Dropdown correctAnswerText;

    private bool hasStarted = false;


    private void Start()
    {
        if (!hasStarted)
        {
            hasStarted = true;
            questionList = new List<Graph_Values>();
            questionList.Add(new Graph_Values(lowestValue, highestValue, quartil_1, quartil_3, median, "Em relação ao grafico seleciona a mediana apresentada.", quartil_1.ToString(), quartil_3.ToString(), median.ToString(), lowestValue.ToString(), 2));
            for (int i = 0; i < 2; i++)
                questionList.Add(new Graph_Values(lowestValue, highestValue, quartil_1, median, quartil_3));


            var cellData = Enumerable.Range(0, questionList.Count)
                    .Select(i => new Example02CellDto { Message = "Pergunta " + i })
                    .ToList();

            currentNumber = 0;
            scrollView.UpdateData(cellData);
            lowestValue = questionList[currentNumber].lowestValue;
            lowestValueText.text = questionList[currentNumber].lowestValue.ToString();

            highestValue = questionList[currentNumber].HighestValue;
            highestValueText.text = questionList[currentNumber].HighestValue.ToString();

            quartil_1 = questionList[currentNumber].Q1;
            quartil_1Text.text = questionList[currentNumber].Q1.ToString();

            median = questionList[currentNumber].Median;
            medianText.text = questionList[currentNumber].Median.ToString();

            quartil_3 = questionList[currentNumber].Q3;
            quartil_3Text.text = questionList[currentNumber].Q3.ToString();

            Question = questionList[currentNumber].Question;
            QuestionText.text = questionList[currentNumber].Question;

            Answer1 = questionList[currentNumber].Answer1;
            Answer1Text.text = questionList[currentNumber].Answer1;

            Answer2 = questionList[currentNumber].Answer2;
            Answer2Text.text = questionList[currentNumber].Answer2;

            Answer3 = questionList[currentNumber].Answer3;
            Answer3Text.text = questionList[currentNumber].Answer3;

            Answer4 = questionList[currentNumber].Answer4;
            Answer4Text.text = questionList[currentNumber].Answer4;

            correctAnswer = questionList[currentNumber].correctAnswer;
            correctAnswerText.value = questionList[currentNumber].correctAnswer;

            currentGraphManager.CreateGraph(new Graph_Values(lowestValue, highestValue, quartil_1, median, quartil_3));
        }

    }

    public void AddQuestion()
    {
        questionList.Add(new Graph_Values(lowestValue, highestValue, quartil_1, median, quartil_3));
        var cellData = Enumerable.Range(0, questionList.Count)
                .Select(i => new Example02CellDto { Message = "Pergunta " + i })
                .ToList();

        scrollView.UpdateData(cellData);
    }

    public void RemoveQuestion()
    {
        if(questionList[currentNumber] != null)
        {
            questionList.RemoveAt(currentNumber);
            var cellData = Enumerable.Range(0, questionList.Count)
                    .Select(i => new Example02CellDto { Message = "Pergunta " + i })
                    .ToList();

            scrollView.UpdateData(cellData);
        }

    }

    public void RestartQuestions()
    {
        questionList = new List<Graph_Values>();
        questionList.Add(new Graph_Values(lowestValue, highestValue, quartil_1, quartil_3, median, "Em relação ao grafico seleciona a mediana apresentada.", quartil_1.ToString(), quartil_3.ToString(), median.ToString(), lowestValue.ToString(), 2));
        for (int i = 0; i < 2; i++)
            questionList.Add(new Graph_Values(lowestValue, highestValue, quartil_1, median, quartil_3));


        var cellData = Enumerable.Range(0, questionList.Count)
                .Select(i => new Example02CellDto { Message = "Pergunta " + i })
                .ToList();

        if(currentNumber > questionList.Count)
        currentNumber = 0;
        scrollView.UpdateData(cellData);
        lowestValue = questionList[currentNumber].lowestValue;
        lowestValueText.text = questionList[currentNumber].lowestValue.ToString();

        highestValue = questionList[currentNumber].HighestValue;
        highestValueText.text = questionList[currentNumber].HighestValue.ToString();

        quartil_1 = questionList[currentNumber].Q1;
        quartil_1Text.text = questionList[currentNumber].Q1.ToString();

        median = questionList[currentNumber].Median;
        medianText.text = questionList[currentNumber].Median.ToString();

        quartil_3 = questionList[currentNumber].Q3;
        quartil_3Text.text = questionList[currentNumber].Q3.ToString();

        Question = questionList[currentNumber].Question;
        QuestionText.text = questionList[currentNumber].Question;

        Answer1 = questionList[currentNumber].Answer1;
        Answer1Text.text = questionList[currentNumber].Answer1;

        Answer2 = questionList[currentNumber].Answer2;
        Answer2Text.text = questionList[currentNumber].Answer2;

        Answer3 = questionList[currentNumber].Answer3;
        Answer3Text.text = questionList[currentNumber].Answer3;

        Answer4 = questionList[currentNumber].Answer4;
        Answer4Text.text = questionList[currentNumber].Answer4;

        correctAnswer = questionList[currentNumber].correctAnswer;
        correctAnswerText.value = questionList[currentNumber].correctAnswer;

        currentGraphManager.CreateGraph(questionList[currentNumber]);

    }


    public void ChangeLowestValue(string answer)
    {
        lowestValue = int.Parse(answer);
        currentGraphManager.CreateGraph(new Graph_Values(lowestValue, highestValue, quartil_1, median, quartil_3));
    }

    public void ChangeHighestValue(string answer)
    {
        highestValue = int.Parse(answer);
        currentGraphManager.CreateGraph(new Graph_Values(lowestValue, highestValue, quartil_1, median, quartil_3));
    }

    public void ChangeQ1(string answer)
    {
        quartil_1 = float.Parse(answer);
        currentGraphManager.CreateGraph(new Graph_Values(lowestValue, highestValue, quartil_1, median, quartil_3));
    }

    public void ChangeQ3(string answer)
    {
        quartil_3 = float.Parse(answer);
        currentGraphManager.CreateGraph(new Graph_Values(lowestValue, highestValue, quartil_1, median, quartil_3));
    }

    public void ChangeMedian(string answer)
    {
        median = float.Parse(answer);
        currentGraphManager.CreateGraph(new Graph_Values(lowestValue, highestValue, quartil_1, median, quartil_3));
    }

    public void QuestionChange(string answer)
    {
        Question = answer;
    }

    public void Answer1Change(string answer)
    {
        Answer1 = answer;
    }

    public void Answer2Change(string answer)
    {
        Answer2 = answer;
    }

    public void Answer3Change(string answer)
    {
        Answer3 = answer;
    }

    public void Answer4Change(string answer)
    {
        Answer4 = answer;
    }

    public void ChangeAnswer(int answer)
    {
        correctAnswer = answer;
    }

    public void ToQuestion()
    {
        QuestionAndAnswer.SetActive(true);
        GraphCreator.SetActive(false);
        QuestionAndAnswer.GetComponent<Question_Creator>().CreateQuestion(new Graph_Values(lowestValue, highestValue, quartil_1, median, quartil_3, Question, Answer1, Answer2, Answer3, Answer4, correctAnswer));
    }

    public void MakeQuestion()
    {
        QuestionAndAnswer.SetActive(true);
        GraphCreator.SetActive(false);
        QuestionAndAnswer.GetComponent<Question_Creator>().CreateQuestion(questionList[currentNumber]);
    }


    public void ChangeQuestion(int value)
    {
        UpdateAnim.SetTrigger("Go");
        Debug.Log(value);
        questionList[currentNumber] = new Graph_Values(lowestValue, highestValue, quartil_1, quartil_3 , median, Question, Answer1, Answer2, Answer3, Answer4, correctAnswer);
        currentNumber = value;
        lowestValue = questionList[currentNumber].lowestValue;
        lowestValueText.text = questionList[currentNumber].lowestValue.ToString();

        highestValue = questionList[currentNumber].HighestValue;
        highestValueText.text = questionList[currentNumber].HighestValue.ToString();

        quartil_1 = questionList[currentNumber].Q1;
        quartil_1Text.text = questionList[currentNumber].Q1.ToString();

        median = questionList[currentNumber].Median;
        medianText.text = questionList[currentNumber].Median.ToString();

        quartil_3 = questionList[currentNumber].Q3;
        quartil_3Text.text = questionList[currentNumber].Q3.ToString();

        Question = questionList[currentNumber].Question;
        QuestionText.text = questionList[currentNumber].Question;

        Answer1 = questionList[currentNumber].Answer1;
        Answer1Text.text = questionList[currentNumber].Answer1;

        Answer2 = questionList[currentNumber].Answer2;
        Answer2Text.text = questionList[currentNumber].Answer2;

        Answer3 = questionList[currentNumber].Answer3;
        Answer3Text.text = questionList[currentNumber].Answer3;

        Answer4 = questionList[currentNumber].Answer4;
        Answer4Text.text = questionList[currentNumber].Answer4;

        correctAnswer = questionList[currentNumber].correctAnswer;
        correctAnswerText.value = questionList[currentNumber].correctAnswer;

        currentGraphManager.CreateGraph(questionList[currentNumber]);
    }


}
