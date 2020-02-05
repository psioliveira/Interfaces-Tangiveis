using System.Collections.Generic;
using UnityEngine;

public class LevelHandler : MonoBehaviour
{
    [SerializeField]
    Transform spawn;

    [SerializeField]
    UI_Input_Manager questions;

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

    // state = false = random;
    bool state = false;

    internal void SetUpRandom()
    {
        state = false;
        CreateLevel();
        text.Message("Ajuda-me a arrumar estes livros todos. Agarra em todos os livros, depois põe na estante.");
    }

    internal void SetUpSequence()
    {
        state = true;
        CreateLevelOrder();
        text.Message("Ajuda-me a arrumar estes livros todos. Agarra em todos os livros, depois põe na estante.");
    }

    internal void CreateLevel()
    {
        levelList = questions.GiveLevel();
        int value = Mathf.FloorToInt(Random.Range(0, levelList.Count - 1));
        levelCreator.GenerateLevel(level.GiveLevel(value));
    }

    internal bool CreateLevelOrder()
    {
        levelList = questions.GiveLevel();

        if (currentValue >= levelList.Count)
        {
            levelCreator.GenerateLevel(level.GiveLevel(currentValue));
            currentValue++;
            return true;
        }
        return false;
    }

    internal void CorrectAnswer()
    {
        correctCount++;
        questionCount++;

        if (!state)
        {
            CreateLevel();
        }
        else
            if (!CreateLevelOrder())
        {
            text.Message("Boa! Acertates " + correctCount + " respostas de " + questionCount + ".");
        }
    }
}
