using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question
{
    public int resultRequired { get; }
    public int leftAnswer { get; }
    public int rightAnswer { get; }
    private float answerSpeed;
    private int BPM { get; } = 0;

/// <summary>
/// Initializes the class. A = Result Required, B = Left Answer, C = Right Answer, D =BPM (Beats per Minute 2 beats per sec = 120
/// </summary>
/// <param name="A"> Result Required</param>
/// <param name="B"> Left Answer</param>
/// <param name="C"> Right Answer</param>
/// <param name="D"> BPM = Beats per Minute 2 beats per sec = 120</param>
    public Question(int A, int B, int C, int D)
    {
        resultRequired = A;
        leftAnswer = B;
        rightAnswer = C;
        BPM = D;
        BPMconverter();
    }
    private void BPMconverter()
    {
        answerSpeed = BPM / 60;
    }
}
