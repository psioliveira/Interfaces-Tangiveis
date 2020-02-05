using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Editors : MonoBehaviour
{
    Animator me;
    void Start()
    {
        me = GetComponent<Animator>();
    }


    public void ExitTrigger()
    {
        me.ResetTrigger("Start");
        me.ResetTrigger("Level");
        me.ResetTrigger("Question");
        me.SetTrigger("Exit");
    }

    public void StartTrigger()
    {
        me.ResetTrigger("Exit");
        me.ResetTrigger("Level");
        me.ResetTrigger("Question");
        me.SetTrigger("Start");
    }

    public void QuestionTrigger()
    {
        me.ResetTrigger("Start");
        me.ResetTrigger("Level");
        me.ResetTrigger("Exit");
        me.SetTrigger("Question");
    }

    public void LevelTrigger()
    {
        me.ResetTrigger("Start");
        me.ResetTrigger("Question");
        me.ResetTrigger("Exit");
        me.SetTrigger("Level");
    }


}
