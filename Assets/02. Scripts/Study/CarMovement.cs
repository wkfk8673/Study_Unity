using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D carRb; // 2D object rigidbody
    float h;



    void Update() // 성능에 따라 다른 프레임으로 실행되는 유니티 기본 함수, 키입력 등에 사용
    {
        h = Input.GetAxis("Horizontal"); // key 입력값 저장

        float v = Input.GetAxis("Vertical");
        
        /// <summary>
        /// Transform 이동, 떨림 발생
        /// transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;
        /// </summary>

    }

    private void FixedUpdate() // 고정 프레임으로 실행되는 유니티 기본 함수, 물리 이동에 주로 사용, 상대적으로 느리고 안정적
    {
        // 키 입력에 대한 변수는 update 구문에서 저장
        // RigidBody 의 속도를 활용한 이동
        carRb.linearVelocityX = h * moveSpeed; 
    }

    private void OnCollisionEnter2D(Collision2D other) // 부딪힌 순간 1회
    {
        Debug.Log("충돌!");
        //other.gameObject.SetActive(false); // 닿은 물체 비활성화
    }

    private void OnCollisionStay2D(UnityEngine.Collision2D other)
    {
        Debug.Log("collsion stay");
        
    }

    private void OnCollisionExit2D(Collision2D other) // 부딪혔다가 떨어질 경우 1회
    {
        Debug.Log("collsion exit");
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger enter");
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Trigger Staty");
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Trigger Exit");
        
    }
}
