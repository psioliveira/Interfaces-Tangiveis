using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationMenu : MonoBehaviour
{
    [SerializeField]
    Animator me;
    [SerializeField]
    Animator edit;
    void Start()
    {
        me = gameObject.GetComponent<Animator>();
    }


    public void ModeTrigger()
    {
        me.ResetTrigger("Menu");
        me.ResetTrigger("Start");
        me.SetTrigger("Mode");
    }

    public void StartTrigger()
    {
        me.ResetTrigger("Menu");
        me.ResetTrigger("Mode");
        me.SetTrigger("Start");
    }

    public void MenuTrigger()
    {
        me.ResetTrigger("Mode");
        me.ResetTrigger("Start");
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

}
