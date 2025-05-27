using UnityEngine;

/// <summary>
/// 캐릭터를 움직이게 하는 스크립트
/// </summary>

public class Movement : MonoBehaviour
{
    // C# 에서 초기화 하지 않은 moveSpeed 는 0f 로 잡고 있음.
    public float moveSpeed;
    // Position 값 접근
    void Start()
    {
        //현재 위치 = 현재 위치 + (0,0,1) 
        //여기서 this 는 AmongUs 캐릭터 (prefab)

    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime; // 보통 사용하는 방법

        // 과거 input 방식으로 작성한 코드 2D프로젝트에서 사용 예정

        /*
        if (Input.GetKey(KeyCode.W)) // 앞으로 가는 기능
        {
            transform.position += moveSpeed * Time.deltaTime * Vector3.forward; // 보통 사용하는 방법
        }
        if (Input.GetKey(KeyCode.S)) // 뒤로 가는 기능
        {
            transform.position += moveSpeed * Time.deltaTime * Vector3.back; // 보통 사용하는 방법
        }
        if (Input.GetKey(KeyCode.A)) // 왼쪽으로 가는 기능
        {
            transform.position += moveSpeed * Time.deltaTime * Vector3.left; // 보통 사용하는 방법
        }
        if (Input.GetKey(KeyCode.D)) // 오른쪽으로 가는 기능
        {
            transform.position += moveSpeed * Time.deltaTime * Vector3.right; // 보통 사용하는 방법
        }
        */

        /// Input System (Old - Legacy)
        /// 입력값에 대한 약속된 시스템
        /// 이동 -> WASD, 화살표키보드
        /// 점프 -> Space
        /// 총쏘기 -> 마우스 왼쪽

        // 부드럽게 증감하는 값
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        // 바로 가속
        // 대각선으로 이동 시 증가 값이 기본 이동보다 큼 
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Vector3 normalDir = dir.normalized; // dir 값을 정규화 한 후 normalDir 에 저장
        
        Debug.Log($"현재 입력 : {dir}");

        transform.position += normalDir * moveSpeed * Time.deltaTime; // 이동하는 기능
        this.transform.LookAt(transform.position + dir); // 어떤 위치를 즉시 바라보는 기능
    }
}
