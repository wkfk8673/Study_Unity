using System;
using UnityEngine;
using UnityEngine.UI;


public class KnightController_Joy : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D knightRb;

    private Vector3 inputDir;

    [SerializeField] private float moveSpeed = 3f;


    private void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() // 물리적인 작업
    {
        Move();
    }


    public void InputJoyStick(float x, float y)
    {
        inputDir = new Vector3(x, y, 0).normalized; // x, y는 조이스틱에서 입력받은 값 / 정규화


        // 조이스틱 입력을 애니메이션에 전달
        animator.SetFloat("JoystickX", inputDir.x);
        animator.SetFloat("JoystickY", inputDir.y);

    }

    private void Move()
    {
        if (inputDir.x != 0)
        {
            // 애니메이션 플립 기능 유지
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);

            knightRb.linearVelocity = inputDir * moveSpeed;
        }
    }
}
