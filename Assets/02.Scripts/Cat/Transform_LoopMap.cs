
using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    /// <summary>
    /// 이동하는 배경과 바닥 타일링
    /// </summary>



    public float moveSpeed = 2f;
    private Vector3 returnPos = new Vector3(30f, 0f, 0f);// 다시 등장하는 위치

    void Start()
    {
        returnPos = new Vector3(30f, transform.position.y, 0f);// 다시 등장하는 위치
    }


    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime; // 배경을 왼쪽으로 이동시키는 기능
        Debug.Log(Time.fixedDeltaTime);

        if (transform.position.x <= -30f) // 오브젝트가 카메라 영역을 빠져나갔을 경우 (x 축 -30)
        {
            transform.position = returnPos; // retunsPos 로 초기화
        }
    }
}
