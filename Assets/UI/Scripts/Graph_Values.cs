using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Please Keep the float values able to reach an INT and reachable on the intervals.
/// </summary>
public class Graph_Values : ScriptableObject
{
    internal int[] values;
    internal int lowestValue;
    internal int HighestValue;
    internal float Q1;
    internal float Q3;
    /// <summary>
    /// Please keep this at 0.25 thank.
    /// </summary>
    internal float intervals = 0.25f;
    internal float Median;
    internal string Question;
    internal string Answer1;
    internal string Answer2;
    internal string Answer3;
    internal string Answer4;
    internal int correctAnswer;

    public Graph_Values(int lowestValue, int HighestValue, float q1, float median, float q3)
    {
        this.lowestValue = lowestValue;
        this.HighestValue = HighestValue;
        Q1 = q1;
        Q3 = q3;

        Median = median;
    }

    public Graph_Values(float q1, float median, float q3)
    {
        Q1 = q1;
        Q3 = q3;
        Median = median;
    }


    public Graph_Values(int lowestValue, int HighestValue,float q1, float q3, 
        float median, string question, string answer1, string answer2, 
        string answer3, string answer4, int correctAnswer)
    {
        this.lowestValue = lowestValue;
        this.HighestValue = HighestValue;
        Q1 = q1;
        Q3 = q3;
        Median = median;
        Question = question;
        Answer1 = answer1;
        Answer2 = answer2;
        Answer3 = answer3;
        Answer4 = answer4;
        this.correctAnswer = correctAnswer;
    }
}
