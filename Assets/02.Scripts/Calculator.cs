using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1; // �������(field)
    public int number2; // �������(field)

    void Start()
    {
        int addReturn = AddMethod(); // �Լ� ȣ��
        int MinusReturn = MinusMethod(); // �Լ� ȣ��

        Debug.Log($"���� �� : {addReturn} / �� �� : {MinusMethod()}");

        Debug.Log($"Result 1 :{AddMethod()}"); // �Լ� ȣ�� �� �� ����
        Debug.Log($"Result 2 :{MinusMethod()}");
    }

    int AddMethod()
    {
        int result = number1 + number2; // result : ��������
        return result; // ����� ����
        //Debug.Log($"Result 1 :{result}"); // ǥ�⸦ ���� ����� �α�
    }

    int MinusMethod()
    {
        int result = number1 - number2; // result : ��������
        return result; // ����� ����
        //Debug.Log($"Result 2 :{result}"); // ǥ�⸦ ���� ����� �α�
    }
}
