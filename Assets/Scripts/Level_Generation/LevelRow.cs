using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRow : MonoBehaviour
{
    [SerializeField]
    List<Transform> myChildren;

    internal List<Transform> GiveChildren()
    {
        return myChildren;
    }
}
