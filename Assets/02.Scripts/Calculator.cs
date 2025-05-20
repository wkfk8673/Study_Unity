using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1; // 멤버변수(field)
    public int number2; // 멤버변수(field)

    void Start()
    {
        int addReturn = AddMethod(); // 함수 호출
        int MinusReturn = MinusMethod(); // 함수 호출

        Debug.Log($"더한 값 : {addReturn} / 뺀 값 : {MinusMethod()}");

        Debug.Log($"Result 1 :{AddMethod()}"); // 함수 호출 및 값 리턴
        Debug.Log($"Result 2 :{MinusMethod()}");
    }

    int AddMethod()
    {
        int result = number1 + number2; // result : 지역변수
        return result; // 결과값 리턴
        //Debug.Log($"Result 1 :{result}"); // 표기를 위한 디버그 로그
    }

    int MinusMethod()
    {
        int result = number1 - number2; // result : 지역변수
        return result; // 결과값 리턴
        //Debug.Log($"Result 2 :{result}"); // 표기를 위한 디버그 로그
    }
}
