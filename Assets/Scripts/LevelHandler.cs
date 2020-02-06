using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void SetUpRandom()
    {
        state = false;
        currentValue = 0;
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

    public void StartLevel()
    {
        SceneManager.LoadScene("Templo_Level1");
    }

    private void CreateLevel()
    {
        levelList = questions.GiveLevel();
        int value = Mathf.FloorToInt(Random.Range(0, levelList.Count - 1));
        levelCreator.GenerateLevel(level.GiveLevel(value));
        anim3.CreateQuestion(levelList[value]);

    }

    public bool CreateLevelOrder()
    {
        levelList = questions.GiveLevel();

        if (currentValue < levelList.Count)
        {
            levelCreator.GenerateLevel(level.GiveLevel(currentValue));
            currentValue++;
            anim3.CreateQuestion(levelList[currentValue]);
            return true;
        }
        return false;
    }

    public void CorrectAnswer()
    {
        correctCount++;
        questionCount++;

        if (state)
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
        anim1.Restart();
        anim2.Restart();
        anim3.Restart();

        GameObject player2 = Instantiate(player, spawn);
        player2.transform.position = spawn.position;
        Destroy(player);
        player = player2;
        player.GetComponent<PlayerMovement>().paused = false;
    }

}
