using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private bool beat = false;
    private bool timingOn = false;
    private bool cooldown = false;
    //HERE ARE THE REFERENCES TO THE TEXTS AND CRAP
    private TextMeshPro leftAnswer;
    private TextMeshPro rightAnswer;
    private TextMeshPro score;
    private TextMeshPro resultRequired;
    private TextMeshPro resultCurrent;
    private TextMeshPro currentCombo;
    private List<Question> QuestionList;
    private QuestionParser parser;
    private int dificultyMod;
    private int currentQuestion;
    public float cooldownTimerMax;
    public int currentScore;
    public int baseScore = 2;
    public int multiplierScore;
    private float cooldownTimerCurr;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<TextMeshPro>();
        resultRequired = GameObject.FindGameObjectWithTag("ResultReq").GetComponent<TextMeshPro>();
        resultCurrent = GameObject.FindGameObjectWithTag("ResultCur").GetComponent<TextMeshPro>();
        currentCombo = GameObject.FindGameObjectWithTag("Combo").GetComponent<TextMeshPro>();
        leftAnswer = GameObject.FindGameObjectWithTag("LeftAnswer").GetComponent<TextMeshPro>();
        rightAnswer = GameObject.FindGameObjectWithTag("RightAnswer").GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if(cooldown == true)
        {
            if (cooldownTimerCurr < cooldownTimerMax)
            {
                cooldownTimerCurr += Time.deltaTime;
            }
            else
            {
                cooldown = false;
            }
        }
        if (Input.GetButtonDown("Left"))
        {
            CheckTiming(QuestionList[currentQuestion].leftAnswer);
        }
        if (Input.GetButtonDown("Right"))
        {
            CheckTiming(QuestionList[currentQuestion].rightAnswer);
        }
    }

    void InitiateGame()
    {
        QuestionList = parser.Parse();
        leftAnswer.text = QuestionList[currentQuestion].leftAnswer.ToString();
        rightAnswer.text = QuestionList[currentQuestion].rightAnswer.ToString();
        resultRequired.text = QuestionList[currentQuestion].resultRequired.ToString();
        currentScore = 0;
    }

    void OpenTiming()
    {
        timingOn = true;
        beat = true;
    }

    void CloseTiming()
    {
        timingOn = false;
        if(beat)
        {
            UpdateScore(-baseScore, dificultyMod);
        }
        beat = false;
    }

    void CheckTiming(int valuetoAdd)
    {
        if(!cooldown)
        {
            cooldown = true;
            if (timingOn)
            {
                if(beat)
                {
                    UpdateResult(valuetoAdd);
                    UpdateScore(baseScore, multiplierScore);
                    beat = false;
                }
            } else
            {
                UpdateScore(-baseScore, dificultyMod);
            }
        }
    }

    void UpdateScore(int baseScore, int multiplier)
    {
        currentScore = baseScore * multiplier;
        multiplierScore += 1;
        score.text = "+" + currentScore.ToString();
    }

    void KeyboardInput()
    {

    }

    void UpdateResult(int valuetoAdd)
    {

    }
}
