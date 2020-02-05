using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextHandler : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI text;

    internal void Message(string value)
    {
        text.text = value;
    }
}
