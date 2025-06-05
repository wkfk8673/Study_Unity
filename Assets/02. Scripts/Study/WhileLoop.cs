using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    public int count = 0;

    void Start()
    {
        while(count < 10)
        {
            count++;

            if (count == 5)
            {
                continue; // 5 일 경우 구문 밖으로 이동
                // break; // 5일 경우 구문 종료
            }

            Debug.Log(count);
        }
    }
}
