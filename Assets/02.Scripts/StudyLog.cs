using UnityEngine;

/// <summary>
/// ����Ƽ �����Ϳ� �ִ� Console View �� Log �� �׽�Ʈ�ϱ� ���� Ŭ����
/// </summary>

public class StudyLog : MonoBehaviour
{// �տ� ����, ����� ����
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start �Լ� ����"); // �Ϲ����� �α� 
        Debug.LogWarning("Start �Լ� ����"); // ��� �α�
        Debug.LogError("Start �Լ� ����"); // ���� �α�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
