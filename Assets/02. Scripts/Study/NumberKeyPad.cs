using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class NumberKeyPad : MonoBehaviour
{
    public string password; // 비밀번호 설정
    public string KeyPadNumber; // 입력한 숫자

    public Animator DoorAnim;
    public GameObject DoorLockUI;

    public void OnInputNumber(string numString) // Button > onClick 이벤트에서 parameter 하나만 받을 수 있음.
    {
        KeyPadNumber += numString; // KeyPadNumber 에 numstring 값을 이어 붙여 저장
        Debug.Log($"{numString} 입력 -> 현재 입력 : {KeyPadNumber}");
    }

    public void OnCheckNumber()
    {
        if (KeyPadNumber == password)
        {
            Debug.Log("문열림");
            DoorAnim.SetTrigger("Open");
            DoorLockUI.SetActive(false);
        }
        else
        {
            KeyPadNumber = "";
            Debug.Log("비밀 번호 오류!");
        }
    }
}
