using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelButton : MonoBehaviour
{
    /// <summary>
    /// 0 = Ice; 1 = Floor; 2 = Wall; 3 = Collectable 
    /// </summary>
    int state = 0;
    Image me;
    internal List<Color> colorList;


    LevelEditor_UI ui;
    TextMeshProUGUI myText;

    internal void StartMe()
    {
        ui = GetComponentInParent<LevelEditor_Row>().GiveUI();
        myText = GetComponentInChildren<TextMeshProUGUI>();
        me = GetComponent<Image>();
        colorList = new List<Color>();
        colorList = ui.GiveColor();
    }


    internal void ChangeState(int value)
    {
        state = value;
        ColorUpdate();
    }

    public void NextState()
    {
        if(state != 3)
        {
            state++;
            ColorUpdate();
        }
        else
        {
            state = 0;
            ColorUpdate();
        }
    }

    internal int GiveState()
    {
        return state;
    }

    private void ColorUpdate()
    {
        switch (state)
        {
            case 0:
                me.color = colorList[0];
                myText.text = "E";
                break;
            case 1:
                me.color = colorList[1];
                myText.text = "C";
                break;
            case 2:
                me.color = colorList[2];
                myText.text = "P";
                break;
            case 3:
                me.color = colorList[3];
                myText.text = "L";
                break;
        }
    }
}
