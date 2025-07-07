using UnityEngine;
using UnityEngine.UI;


public class KnightController_Key : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D knightRb;

    private Collider2D knightColl;
    [SerializeField] private Image hpBar;

    private Vector3 inputDir;
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float jumpPower = 15f;

    public float hp = 100f;
    public float currHp;

    private float atkDamage = 3f;

    private bool isGround = false;
    private bool isAttack = false;
    private bool isCombo = false;
    private bool isLadder = false;
    private bool isPushPlatform = false;


    private void Start()
    {
        animator = GetComponent<Animator>();
        knightRb = GetComponent<Rigidbody2D>();
        knightColl = GetComponent<Collider2D>();
    }
    private void Update() // 일반적인 작업
    {
        InputKeyboard();
        Jump();
        Attack();
    }

    private void FixedUpdate() // 물리적인 작업
    {
        Move();
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Monster"))
        {
            Debug.Log($"{atkDamage}로 공격");
        }

        if (other.CompareTag("Ladder"))
        {
            isLadder = true;
            knightRb.gravityScale = 0f; // 중력값 0으로 할당, 사다리 낙하 방지
            knightRb.linearVelocity  = Vector2.zero; // x,y 축 이동속도 정지
        }

        if (other.CompareTag("Push"))
        {
            isGround = true;
            isPushPlatform = true;
            animator.SetBool("isGround", true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ladder"))
        {
            isLadder = false;
            knightRb.gravityScale = 3f; // 중력값 3으로 다시 초기화
            knightRb.linearVelocity  = Vector2.zero; // x,y 축 이동속도 정지
        }
        if (other.CompareTag("Push"))
        {
            isGround = false;
            isPushPlatform = false;
            animator.SetBool("isGround", false);
        }
    }

    private void InputKeyboard()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        inputDir = new Vector3(h, v, 0);

        animator.SetFloat("JoystickX", inputDir.x);
        animator.SetFloat("JoystickY", inputDir.y);

        if (inputDir.y < 0)
        {
            GetComponent<CapsuleCollider2D>().size = new Vector2(0.7f, 0.3f);
            GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0.35f);
        }
        else
        {
            GetComponent<CapsuleCollider2D>().size = new Vector2(0.7f, 1.7f);
            GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0.85f);
        }

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround && !isPushPlatform) // 일시적인 이벤트, update 구문에서 반복 계산할 필요 없음
        {
            animator.SetTrigger("Jump");
            knightRb.AddForceY(jumpPower, ForceMode2D.Impulse); // 한번에 강한힘
        }
        if (knightRb.linearVelocityY > 30f)
        {
            animator.SetTrigger("Jump");
        }
    }

    private void Move()
    {
        
        if (inputDir.x != 0)
        {
            // SpriteFlip
            var scaleX = inputDir.x > 0 ? 1 : -1;
            transform.localScale = new Vector3(scaleX, 1, 1);

            // x 축 이동
            knightRb.linearVelocityX = inputDir.x * moveSpeed; 
        }
        if (isLadder && inputDir.y != 0)
        {
            knightRb.linearVelocityY = inputDir.y * moveSpeed;
        }
    }

    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (!isAttack)
            {
                isAttack = true;
                atkDamage = 3f;
                animator.SetTrigger("Attack");
            }
            else
            {
                isCombo = true;
            }
        }
    }

    public void WaitCombo()
    {
        if (isCombo)
        {
            atkDamage = 5f;
            animator.SetBool("isCombo", true);
        }
        else
        {
            isAttack = false;
            animator.SetBool("isCombo", false);
        }
    }

    public void EndCombo()
    {
        isAttack = false;
        isCombo = false;
        animator.SetBool("isCombo", false);
    }

}
