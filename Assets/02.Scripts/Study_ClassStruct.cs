using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// C# ���α׷��ֿ��� Class �� Struct �� ���̸� �ľ�
/// </summary>

public class Study_Class
{
    public int number;
    public Study_Class(int number) //������
    {
        this.number = number;
    }
}

public struct Study_Struct
{
    public int number;
    public Study_Struct(int number) //������
    {
        this.number = number;
    }

}

public class Study_ClassStruct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Ŭ����------------------------------------------");
        Study_Class c1 = new Study_Class(12);
        Study_Class c2 = c1;
        Debug.Log($"c1 :{c1.number} / c2 : {c2.number}");

        c1.number = 100;
        Debug.Log($"c1 :{c1.number} / c2 : {c2.number}");

        Debug.Log("����ü------------------------------------------");
        Study_Struct s1 = new Study_Struct(45);
        Study_Struct s2 = s1;
        Debug.Log($"s1 :{s1.number} / s2 : {s2.number}");

        s1.number = 100;
        Debug.Log($"s1 :{s1.number} / s2 : {s2.number}");

    }

}
