using UnityEngine;
using UnityEngine.VFX;

public class KnightController_Key : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D knightRb;
    private bool isGround = false;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpPower = 15f;

    private void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
    }
    private void Update() // 일반적인 작업
    {
        InputKeyboard();
        SetAnimation();
        SetAnimationFlip();
        Jump();
    }

    private void FixedUpdate() // 물리적인 작업
    {
        Move();
    }

    private void InputKeyboard()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        inputDir = new Vector3(h, v, 0);

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround) // 일시적인 이벤트, update 구문에서 반복 계산할 필요 없음
        {
            animator.SetTrigger("Jump");
            knightRb.AddForceY(jumpPower, ForceMode2D.Impulse); // 한번에 강한힘
        }
    }

    private void Move()
    {
        if (inputDir.x != 0)
        {
            knightRb.linearVelocityX = inputDir.x * moveSpeed;
        }
    }

    private void SetAnimation()
    {
        // SetAnimation
        if (inputDir.x != 0)
        {
            knightRb.linearVelocityX = inputDir.x * moveSpeed;
            animator.SetBool("isRun", true);
        }
        else if (inputDir.x == 0)
        {
            animator.SetBool("isRun", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", true);
            isGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("isGround", false);
            isGround = false;
        }
    }

    private void SetAnimationFlip()
    {
        // SpriteFlip
        if (inputDir.x != 0)
        {
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);
        }
    }

}
