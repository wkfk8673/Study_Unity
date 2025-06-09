using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class StudyFor : MonoBehaviour
{

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log($"{i} / {j}");
            }
        }
    }
}
