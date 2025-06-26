using System.Collections;
using TMPro;
using UnityEngine;

public class TypingText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textUI;
    private string currText;
    [SerializeField] private float typingSpeed = 0.1f; //타이핑 속도 조절 변수

    private void Awake()
    {
        currText = textUI.text;
    }

    private void OnEnable()
    {
        textUI.text = string.Empty; //텍스트 초기화
        StartCoroutine(TypingRoutine());
    }

    IEnumerator TypingRoutine()
    {
        int textLength = currText.Length;
        for (int i = 0; i < textLength; i++)
        {
            textUI.text += currText[i]; //한 글자씩 추가
            yield return new WaitForSeconds(typingSpeed); //타이핑 지연 속도만큼 대기
        }
    }

}

