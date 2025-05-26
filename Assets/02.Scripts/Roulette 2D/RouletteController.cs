using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;
    public bool isStop = false; // 기본값 false

    private void Start()
    {
        // 처음 회전 속도를 0으로 초기화
        rotSpeed = 0f;
    }
    void Update()
    {
        this.transform.Rotate(Vector3.forward * rotSpeed); //Z 축 기준 회전
        //this.transform.Rotate(0f, 0f, rotSpeed); // 이 방식도 가능, 함수 오버로드 (매개변수 차이)

        // 마우스 왼쪽 버튼 클릭 시 회전하는 기능
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10f;
        }

        // 스페이스 버튼 눌렀을 때 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 속도를 감소 시키기 위해 연속 실행 필요
            isStop = true;
        }
        if (isStop == true)
        {
            // rotSpeed 속도 감소
            // rotSpeed = rotSpeed * 0.98
            rotSpeed *= 0.98f;

            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0;
                isStop = false;
            }
        }
    }
}
