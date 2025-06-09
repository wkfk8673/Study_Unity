using Cat;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public SoundManager soundManager; // 개체 참조
    private Rigidbody2D CatRb; // cat
    private Animator catAnim;



    public float jumpPower = 10f;
    private bool isGround = false;
    private float limitPower = 10f;

    private int jumpCnt = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CatRb = GetComponent<Rigidbody2D>();
        catAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        catJump();
    }

    private void catJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCnt < 2)
        {
            catAnim.SetTrigger("Jump");
            // 점프 == y 축 방향으로 힘을 일시에 주는 것.
            CatRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCnt++;

            soundManager.OnJumpSound();

            if (CatRb.linearVelocityY > limitPower)
            {
                CatRb.linearVelocityY = limitPower;
            }
        }

        var catRotation = transform.eulerAngles;
        catRotation.z = CatRb.linearVelocity.y * 1.5f;
        transform.eulerAngles = catRotation;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            catAnim.SetBool("Ground", true);
            isGround = true;
            jumpCnt = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            catAnim.SetBool("Ground", false);
            isGround = false;
        }
    }
}
