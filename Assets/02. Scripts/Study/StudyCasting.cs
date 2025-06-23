using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class StudyCasting : MonoBehaviour
{
    private int number1 = 1;
    private float number2 = 1.99f;

    List<Orc> orcs = new List<Orc>();
    List<Goblin> goblins = new List<Goblin>();

    List<Monster> monsters = new List<Monster>();

    private void Start()
    {
        /*
        int num0 = 0;
        int num1 = 1;
        int num2 = 2;
        int num100 = 100;

        float fNum0 = 0f;
        float fNum1 = 1.57f;
        float fNum2 = 3.14f;


        string str1 = "안녕하세요";
        string str2 = "true";
        string str3 = "false";

        Debug.Log("Num0 : " + Convert.ToBoolean(num0));
        Debug.Log("Num1 : " + Convert.ToBoolean(num1));
        Debug.Log("Num2 : " + Convert.ToBoolean(num2));
        Debug.Log("Num100 : " + Convert.ToBoolean(num100));

        Debug.Log("fNum0 : " + Convert.ToBoolean(fNum0));
        Debug.Log("fNum1 : " + Convert.ToBoolean(fNum1));
        //Debug.Log("fNum2 : " + Convert.ToBoolean(fNum2)); 오류

        //Debug.Log("str1 : " + Convert.ToBoolean(str1)); 오류
        Debug.Log("str2 : " + Convert.ToBoolean(str2));
        Debug.Log("str3 : " + Convert.ToBoolean(str3));
        */

        //하나하나 불러오기 귀찮음
        //동일 클래스를 상속받았으니 형변환 가능

        Orc o = new Orc();
        Goblin g = new Goblin();

        monsters.Add(o); // 동일 클래스 상속으로 인해, 몬스터 타입에 orc / goblin 형변환 사용 가능
        monsters.Add(g);

        // 업 캐스팅, 문제없이 사용가능
        // 명시적 형변환
        Monster M1 = (Monster) o; 
        Monster M2 = (Monster) g;

        // 다운 캐스팅
        // 상위 범위를 하위에 할당하면 문제 발생
        //Monster m5 = new Monster();
        //Orc o2 = (Orc)m5; 

    }
}
