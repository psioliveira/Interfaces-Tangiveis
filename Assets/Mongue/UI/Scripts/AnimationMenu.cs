using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class AnimationMenu : MonoBehaviour
{
    [SerializeField]
    Animator me;
    [SerializeField]
    Animator edit;

    [SerializeField]
    TextMeshProUGUI message;


    void Start()
    {
        me = gameObject.GetComponent<Animator>();
    }

    public void End(string value)
    {
        me.ResetTrigger("Start");
        me.ResetTrigger("Menu");
        me.ResetTrigger("Mode");
        me.ResetTrigger("AfterEnd");
        me.SetTrigger("End");
        message.text = value;
    }



    public void ModeTrigger()
    {
        me.ResetTrigger("Menu");
        me.ResetTrigger("Start");
        me.ResetTrigger("AfterEnd");
        me.SetTrigger("Mode");
    }

    public void StartTrigger()
    {
        me.ResetTrigger("Menu");
        me.ResetTrigger("Mode");
        me.ResetTrigger("AfterEnd");
        me.SetTrigger("Start");
    }

    public void MenuTrigger()
    {
        me.ResetTrigger("Mode");
        me.ResetTrigger("Start");
        me.ResetTrigger("AfterEnd");
        me.SetTrigger("Menu");
    }

    private void OnEnable()
    {
        StartTrigger();
    }

    public void ActivateEditor()
    {
        edit.SetTrigger("Start");
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        me.ResetTrigger("Mode");
        me.ResetTrigger("Start");
        me.ResetTrigger("Menu");
        me.SetTrigger("Start");
        edit.SetTrigger("Restart");
    }

}
