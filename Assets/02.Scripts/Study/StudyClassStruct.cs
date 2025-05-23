using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// C# 프로그래밍에서 Class 와 Struct 의 차이를 파악
/// </summary>

public class Study_Class
{
    public int number;
    public Study_Class(int number) //생성자
    {
        this.number = number;
    }
}

public struct Study_Struct
{
    public int number;
    public Study_Struct(int number) //생성자
    {
        this.number = number;
    }

}

public class StudyClassStruct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("클래스------------------------------------------");
        Study_Class c1 = new Study_Class(12);
        Study_Class c2 = c1;
        Debug.Log($"c1 :{c1.number} / c2 : {c2.number}");

        c1.number = 100;
        Debug.Log($"c1 :{c1.number} / c2 : {c2.number}");

        Debug.Log("구조체------------------------------------------");
        Study_Struct s1 = new Study_Struct(45);
        Study_Struct s2 = s1;
        Debug.Log($"s1 :{s1.number} / s2 : {s2.number}");

        s1.number = 100;
        Debug.Log($"s1 :{s1.number} / s2 : {s2.number}");

    }

}
