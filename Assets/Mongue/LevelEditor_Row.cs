using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEditor_Row : MonoBehaviour
{
    [SerializeField]
    public List<LevelButton> list;

    [SerializeField]
    LevelEditor_UI ui;

    internal LevelEditor_UI GiveUI()
    {
        return ui;
    }
}
