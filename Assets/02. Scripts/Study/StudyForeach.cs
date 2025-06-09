using System;
using UnityEngine;

public class StudyForeach : MonoBehaviour
{
    public string findName;
    public string[] persons = new string[5] { "바냐", "드미트리", "그루첸카", "알료샤", "카체리나" };
    void Start()
    {
        FindPerson(findName);
    }

    private void FindPerson(string name)
    {
        bool isFind = false;
        int count = 0;
        foreach (var person in persons)
        {
            count++;
            Debug.Log($"{count} 회 실행");
            if (person == name)
            {
                Debug.Log($"해당 유저 {name} 이(가) 존재합니다.");
                isFind = true;
                break;
            }
        }
        if (!isFind)
        {
            Debug.Log($"해당 유저 {name} 이(가) 존재하지 않습니다.");
        }

    }
}
