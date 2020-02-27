using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelHandler : MonoBehaviour
{
    [SerializeField]
    Transform spawn;

    [SerializeField]
    UI_Input_Manager questions;

    [SerializeField]
    GameObject player;

    [SerializeField]
    LevelEditor_UI level;

    List<Graph_Values> levelList;

    [SerializeField]
    LevelGrid levelCreator;

    [SerializeField]
    TextHandler text;

    int currentValue = 0;

    int correctCount = 0;
    int questionCount = 0;


    [SerializeField]
    Animation_Editors anim1;

    [SerializeField]
    AnimationMenu anim2;

    [SerializeField]
    Question_Creator anim3;


    // state = false = random;
    bool state = false;

    int maxNum = 1;
    int currentNum = 0;

    [SerializeField]
    TMP_InputField input;

    [SerializeField]
    TextMeshProUGUI feedback;

    [SerializeField]
    TextMeshProUGUI counter;

    private void Start()
    {
        CounterUpdate();
    }

    public void SetUpRandom()
    {
        state = false;
        currentValue = 0;
        currentNum = 0;
        correctCount = 0;
        CreateLevel();
        text.Message("Ajuda-me a arrumar estes livros todos. Agarra em todos os livros, depois põe na estante.");
    }

    public void SetUpSequence()
    {
        state = true;
        currentValue = 0;
        correctCount = 0;
        CreateLevelOrder();
        text.Message("Ajuda-me a arrumar estes livros todos. Agarra em todos os livros, depois põe na estante.");

    }

    public void ChangingMaxRan(string value)
    {
        maxNum = Convert.ToInt32(value);
        if(maxNum == 0)
        {
            maxNum = 1;
            input.text = "";
            feedback.text = "Por favor insira valores maiores de 0";
        }
        else
        {
            input.text = "";
            feedback.text = "";

        }
        CounterUpdate();
    }

    private void CounterUpdate()
    {
        counter.text = "- "+ maxNum.ToString() + " Perguntas";
    }


    public void StartLevel()
    {
        SceneManager.LoadScene("Templo_Level1");
    }

    private void CreateLevel()
    {
        if(currentNum < maxNum)
        {
            levelList = new List<Graph_Values>();
            levelList = questions.GiveLevel();
            int value = Mathf.FloorToInt(UnityEngine.Random.Range(0, levelList.Count - 1));

            levelCreator.GenerateLevel(level.GiveLevel(levelList[value].levelIndex));

            anim3.CreateQuestion(levelList[currentValue]);
            currentValue++;
            GameObject player2 = Instantiate(player, spawn);
            player2.transform.position = spawn.position;
            Destroy(player);
            player = player2;
            player.GetComponent<PlayerMovement>().paused = false;
            currentNum++;
        }
        else
        {
            correctCount = 0;
            questionCount = 0;
            anim2.gameObject.SetActive(true);
            anim2.End("Acertates " + correctCount + " respostas de " + questionCount + ".");
        }

    }

    public bool CreateLevelOrder()
    {
        levelList = questions.GiveLevel();

        if (currentValue < levelList.Count)
        {

            levelCreator.GenerateLevel(level.GiveLevel(levelList[currentValue].levelIndex));

            anim3.CreateQuestion(levelList[currentValue]);
            currentValue++;
            GameObject player2 = Instantiate(player, spawn);
            player2.transform.position = spawn.position;
            Destroy(player);
            player = player2;
            player.GetComponent<PlayerMovement>().paused = false;
            return true;
        }
        correctCount = 0;
        questionCount = 0;
        anim2.gameObject.SetActive(true);
        anim2.End("Acertates " + correctCount + " respostas de " + questionCount + ".");
        return false;
    }

    public void CorrectAnswer()
    {
        correctCount++;
        questionCount++;

        if (!state)
        {
            CreateLevel();
            text.Message("Boa! Acertates " + correctCount + " respostas de " + questionCount + ".");

            GameObject player2 = Instantiate(player, spawn);
            player2.transform.position = spawn.position;
            Destroy(player);
            player = player2;
            player.GetComponent<PlayerMovement>().paused = false;
        }
        else
            if (CreateLevelOrder())
        {
            text.Message("Boa! Acertates " + correctCount + " respostas de " + questionCount + ".");

            GameObject player2 = Instantiate(player, spawn);
            player2.transform.position = spawn.position;
            Destroy(player);
            player = player2;
            player.GetComponent<PlayerMovement>().paused = false;
        }
    }

    public void WrongAnswer()
    {
        questionCount++;

        if (!state)
        {
            CreateLevel();
            text.Message("Boa! Acertates " + correctCount + " respostas de " + questionCount + ".");

            GameObject player2 = Instantiate(player, spawn);
            player2.transform.position = spawn.position;
            Destroy(player);
            player = player2;
            player.GetComponent<PlayerMovement>().paused = false;
        }
        else
            if (CreateLevelOrder())
        {
            text.Message("Boa! Acertates " + correctCount + " respostas de " + questionCount + ".");

            GameObject player2 = Instantiate(player, spawn);
            player2.transform.position = spawn.position;
            Destroy(player);
            player = player2;
            player.GetComponent<PlayerMovement>().paused = false;
        }
    }

    public void Restart()
    {
        correctCount = 0;
        questionCount = 0;
        anim1.Restart();
        anim2.gameObject.SetActive(true);
        anim2.Restart();
        anim3.Restart();
    }

}
