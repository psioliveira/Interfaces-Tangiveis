using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelEditor_UI : MonoBehaviour
{
    [SerializeField]
    Color stateSlip;

    [SerializeField]
    Color stateGround;

    [SerializeField]
    Color stateWall;

    [SerializeField]
    Color stateBook;

    List<Color> colorList;

    static List<List<LevelButton>> level;

    [SerializeField]
    List<LevelEditor_Row> row;


    [SerializeField]
    TMP_InputField me;

    int levelIndex = 0;

    int levelCount = 0;

    string currentName = "Change Me";

    static List<Level> levelList;

    [SerializeField]
    TMP_Dropdown dropOption, dropOption2;

    LevelGrid levelCreator;

    private void Awake()
    {
        level = new List<List<LevelButton>>();
        foreach(LevelEditor_Row rowToAdd in row)
        {
            level.Add(rowToAdd.list);
        }
        
        colorList = new List<Color>();
        colorList.Add(stateSlip);
        colorList.Add(stateGround);
        colorList.Add(stateWall);
        colorList.Add(stateBook);
        levelCreator = GameObject.FindGameObjectWithTag("Level_Spawner").GetComponent<LevelGrid>();


    }
    private void Start()
    {
        
        LoadFiles();
    }

    public void ChangeIndex(int toChange)
    {
        levelIndex = toChange;
        RefreshToCurrentIndex();
        UpdateLevel();
    }

    public void AddNewLevel()
    {
        levelCount++;
        
        LevelEditor_Spec temp = new LevelEditor_Spec();
        temp.levelCount = levelCount;
        string toSave = JsonUtility.ToJson(temp);

        File.WriteAllText(Application.dataPath + "/numLevels.json", toSave);

        levelList.Add(new Level());
        Debug.Log(levelList);

        levelIndex = levelList.Count - 1;

        Level_Scriptable temp1 = new Level_Scriptable();
        temp1.myName = levelList[levelIndex].GiveName();
        temp1.level = levelList[levelIndex].GiveArray();
        temp1.message = levelList[levelIndex].GiveMessage();
        toSave = JsonUtility.ToJson(temp1);
        Debug.Log(toSave);

        File.WriteAllText(Application.dataPath + "/Level" + levelIndex.ToString() + ".json", toSave);
        RefreshToCurrentIndex();
        DropDownUpdate();
    }

    private void LoadFiles()
    {
        levelList = new List<Level>();
        Debug.Log(levelList);
        if (File.Exists(Application.dataPath + "/numLevels.json"))
        {
            string temp = File.ReadAllText(Application.dataPath + "/numLevels.json");
            LevelEditor_Spec meme = new LevelEditor_Spec();
            JsonUtility.FromJsonOverwrite(temp, meme);

            levelCount = meme.levelCount;
            if (levelCount >= 1)
            {
                for (int i = 0; i < (levelCount); i++)
                {
                    string temp1 = File.ReadAllText(Application.dataPath + "/Level" + i.ToString() + ".json");
                    Level_Scriptable temp2 = new Level_Scriptable();
                    JsonUtility.FromJsonOverwrite(temp1, temp2);
                    levelList.Add(new Level(temp2));
                }
            }
            DropDownUpdate();
            RefreshToCurrentIndex();
            UpdateLevel();
        }
        else
        {
            AddNewLevel();
        }
    }

    public void RefreshToCurrentIndex()
    {
        currentName = levelList[levelIndex].GiveName();
        List<int> decompiled = levelList[levelIndex].GiveLevel();
        int i = 0;
        Debug.Log(levelList.Count);
        foreach (List<LevelButton> rowtoCheck in level)
        {
            foreach (LevelButton button in rowtoCheck)
            {
                button.ChangeState(decompiled[i]);
                i++;
            }
        }
    }

    private List<int> DecompileLevel(List<List<LevelButton>> toDecompile)
    {
        List<int> decompiledList = new List<int>();
        foreach (List<LevelButton> rowtoCheck in toDecompile)
        {
            foreach (LevelButton button in rowtoCheck)
            {
                decompiledList.Add(button.GiveState());
            }
        }
        return decompiledList;
    }

    public void SaveLevel()
    {
        levelList[levelIndex] = new Level(DecompileLevel(level), currentName);
        Level_Scriptable temp = new Level_Scriptable();
        temp.myName = levelList[levelIndex].GiveName();
        temp.level = levelList[levelIndex].GiveLevel().ToArray();
        temp.message = levelList[levelIndex].GiveMessage();
        string toSave = JsonUtility.ToJson(temp);
        Debug.Log(toSave);

        File.WriteAllText(Application.dataPath + "/Level" + levelIndex.ToString() + ".json", toSave);
        UpdateLevel();
    }

    internal List<Color> GiveColor()
    {
        return colorList;
    }

    public void RemoveCurrentLevel()
    {
        if(levelList.Count > 1)
        {
            levelList.RemoveAt(levelIndex);
            levelCount--;

            LevelEditor_Spec temp3 = new LevelEditor_Spec();
            temp3.levelCount = levelCount;
            string toSave = JsonUtility.ToJson(temp3);

            File.WriteAllText(Application.dataPath + "/numLevels.json", toSave);
        }



        int i = 0;
        foreach(Level levelToWrite in levelList)
        {
            Level_Scriptable temp = new Level_Scriptable();
            temp.myName = levelToWrite.GiveName();
            temp.level = levelToWrite.GiveLevel().ToArray();
            temp.message = levelToWrite.GiveMessage();
            string toSave = JsonUtility.ToJson(temp);
            Debug.Log("Delete");
            File.WriteAllText(Application.dataPath + "/Level" + i.ToString() + ".json", toSave);
            i++;
        }
        File.Delete(Application.dataPath + "/Level" + levelList.Count.ToString() + ".json");
        Debug.Log(Application.dataPath + "/Level" + levelList.Count.ToString() + ".json");
        if(levelIndex >= levelCount)
        {
            levelIndex = 0;
        }
        RefreshToCurrentIndex();
        DropDownUpdate();
    }

    private void DropDownUpdate()
    {
        dropOption.ClearOptions();
        dropOption2.ClearOptions();

        List<string> stringToAdd = new List<string>();

        foreach(Level levelToAdd in levelList)
        {
            stringToAdd.Add(levelToAdd.GiveName());
        }


        dropOption.AddOptions(stringToAdd);
        dropOption2.AddOptions(stringToAdd);
        dropOption.value = levelIndex;
        dropOption.value = 0;
    }

    public void ChangeName(string valueToChange)
    {
        currentName = valueToChange;
        levelList[levelIndex].ChangeName(valueToChange);
        DropDownUpdate();


        me.text = "";
        SaveLevel();
        
    }

    public void UpdateLevel()
    {
        levelCreator.GenerateLevel(levelList[levelIndex].GiveLevel());
    }
}
