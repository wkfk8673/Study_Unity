
using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    /// <summary>
    /// 이동하는 배경과 바닥 타일링
    /// </summary>



    public float moveSpeed = 2f;
    public float returnPosX = 15f;
    public float randomPosY;


    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime; // 배경을 왼쪽으로 이동시키는 기능
        Debug.Log(Time.fixedDeltaTime);

        if (transform.position.x <= -returnPosX) // 오브젝트가 카메라 영역을 빠져나갔을 경우 (x 축 -30)
        {
            randomPosY = Random.Range(-8f, -4f);
            transform.position = new Vector3(returnPosX,randomPosY,0); // retunsPos 로 초기화
        }
    }
}
