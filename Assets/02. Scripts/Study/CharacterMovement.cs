using System;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D CharacterRb;
    private SpriteRenderer[] renderers; // 추후 이미지 반전을 위해 GameObj 말고 SpriteRender 이용
    
    private float h; // 키 입dd력을 받을 h 변수
    private float v; // 캐릭터의 낙하 속도

    public float moveSpeed;

    private bool isGround;
    public float jumpPower;
    private int jumpCount;


    private void Start()
    {
        CharacterRb = GetComponent<Rigidbody2D>(); // rigidbody 할당
        renderers = GetComponentsInChildren<SpriteRenderer>(true);
    }

    private void Update()
    {
        h = Input.GetAxis("Horizontal"); // 키 값을 할당
        v = CharacterRb.linearVelocityY;

        Jump();
        SpriteOnOff();
    }

    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// 스페이스 바 입력 시 최대 2단 점프 기능
    /// </summary>
    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && jumpCount < 2)
        {
            CharacterRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCount++;
        }
    }

    /// <summary>
    /// 바닥에 떨어질 경우 충돌 시작 감지 및 점프 횟수 초기화
    /// </summary>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
        jumpCount = 0;
    }

    /// <summary>
    /// 바닥에서 떨어질 경우 충돌 종료 감지
    /// </summary>
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = false;
    }

    /// <summary>
    /// 캐릭터 상태에 따라 애니메이션 스프라이트를 onoff 하는 기능
    /// </summary>
    private void SpriteOnOff()
    {
        renderers[0].gameObject.SetActive(h == 0 && isGround);
        renderers[1].gameObject.SetActive(h != 0 && isGround);
        renderers[2].gameObject.SetActive(!isGround && v >= 0);
        renderers[3].gameObject.SetActive(!isGround && v < 0);
    }

    /// <summary>
    /// 캐릭터 움직임에 따라 이미지의 Flip 상태가 변하는 기능
    /// </summary>
    private void Move()
    {
        if (h < 0) // 왼쪽 이동
        {
            foreach (SpriteRenderer r in renderers)
            {
                r.flipX = true; // 모든 flipX 뒤집기
            }
        }

        else if (h > 0) // 오른쪽 이동
        {
            foreach (SpriteRenderer r in renderers)
            {
                r.flipX = false; // 모든 flipX 원복
            }
        }
        CharacterRb.linearVelocityX = h * moveSpeed;
    }
}
