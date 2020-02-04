using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Level
{

    List<int> level;

    string myName = "Update me";

    string message = "Não tenho nenhuma idea de o que dizer!";

    public Level()
    {
        level = new List<int>();
        myName = "Nivel";
        for (int i = 0; i < 160; i++)
        {
            level.Add(0);
        }
    }

    public Level(List<int> toSaveLevel, string toSaveString)
    {
        level = new List<int>();
        myName = toSaveString;
        foreach(int value in toSaveLevel)
        {
            level.Add(value);
        }
    }

    internal void UpdateInfo(List<int> toSaveLevel, string toSaveString)
    {
        level = new List<int>();
        myName = toSaveString;
        foreach (int value in toSaveLevel)
        {
            level.Add(value);
        }
    }

    internal List<int> GiveLevel()
    {
        return level;
    }

    internal string GiveName()
    {
        return myName;
    }

    internal void ChangeName(string newname)
    {
        myName = newname;
    }

    internal string GiveMessage()
    {
        return message;
    }

    internal void ChangeMessage(string toSwap)
    {
        message = toSwap;
    }

    internal List<List<int>> Decode()
    {
        List<List<int>> toGive = new List<List<int>>();
        int index = 0;
        for(int i = 0; i < 10; i++)
        {
            List<int> temp = new List<int>();
            for (int x = 0; x < 16; i++)
            {
                temp.Add(level[index]);
                index++;
            }
            toGive.Add(temp);
        }
        return toGive;
    }

    public Level(Level_Scriptable levelCopy)
    {
        level = new List<int>();
        level = new List<int>(levelCopy.level);
        myName = levelCopy.myName;
        message = levelCopy.message;
    }

    public int[] GiveArray()
    {
        int x = 0;
        int[] array = new int[level.Count];
        foreach(int i in level)
        {
            array[x] = i;
            x++;
        }
        return array;
    }
}
