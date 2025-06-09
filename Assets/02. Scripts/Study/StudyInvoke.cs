using UnityEngine;

public class StudyInvoke : MonoBehaviour
{
    public float timer = 5f;
    public int count = 10;

    void Start()
    {
        //Invoke("Method1", 3f); // 지연 후 실행
        InvokeRepeating("Bomb", 0f, 1f); // 반복 Invoke ("함수명", 처음 지연시간, 몇초마다 실행)
    }

    private void Bomb()
    {
        Debug.Log($"현재 남은 시간 {count}초");
        count--;

        if ( count == 0)
        {
            Debug.Log("폭탄 터짐");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            CancelInvoke("Bomb");
            Debug.Log("폭탄이 해제 되었습니다.");
        }

    }
}
