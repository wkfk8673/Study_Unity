using UnityEngine;

/// <summary>
/// 유니티 에디터에 있는 Console View 에 Log 를 테스트하기 위한 클래스
/// </summary>

public class StudyLog : MonoBehaviour
{// 앞에 숫자, 언더바 제외
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start 함수 실행"); // 일반적인 로그 
        Debug.LogWarning("Start 함수 실행"); // 경고 로그
        Debug.LogError("Start 함수 실행"); // 에러 로그
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
