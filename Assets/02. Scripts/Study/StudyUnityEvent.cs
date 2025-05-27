using UnityEngine;

public class StudyUnityEvent : MonoBehaviour
{
    int i = 0;
    void Awake()
    {
        // 스크립트가 비활성화 되어 있어도, 해당 컴포넌트 초기화를 위해 실행됨
        // 스크립트가 포함된 오브젝트가 비활성화 될 경우 실행되지 않음
        Debug.Log($"Awake {i++}");
    }
    void Start()
    {
        Debug.Log($"Start {i++}");
    }
    private void OnEnable()
    {
        Debug.Log($"OnEnable {i++}"); // 오브젝트가 꺼졌다가 켜지는 순간에 다시 실행됨
    }    
    private void OnDisable()
    {
        Debug.Log($"OnDisable {i++}"); // 오브젝트가 꺼졌다가 켜지는 순간에 다시 실행됨
    }
    void Update()
    {
        
    }
}
