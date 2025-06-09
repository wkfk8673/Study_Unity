using System;
using UnityEngine;

public class StudySwitch : MonoBehaviour
{
    public enum CalculationType { PLUS = 10, MINUS = 20, MULTIPLY, DIVIDE} // 열거형 생성

    public CalculationType calculationType = CalculationType.PLUS; // 열거형 할당

    public int input1, input2, result;

    private void Start()
    {
        Debug.Log($"result = {Calculation()}");
    }

    private int Calculation()
    {
        switch (calculationType)
        {
            case CalculationType.PLUS:
                result = input1 + input2;
                break;
            case CalculationType.MINUS:
                result = input1 - input2;
                break;
            case CalculationType.MULTIPLY:
                result = input1 * input2;
                break;
            case CalculationType.DIVIDE:
                result = input1 / input2;
                break;
            default:
                break;
        }
        return result;
    }
}


