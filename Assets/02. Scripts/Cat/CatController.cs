using UnityEngine;

public class CatController : MonoBehaviour
{

    private Rigidbody2D CatRb; // cat
    private int jumpCnt = 0;

    private bool isGround = false;

    public float jumpPower = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CatRb = GetComponent<Rigidbody2D>(); // 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCnt < 2)
        {
            // 점프 == y 축 방향으로 힘을 일시에 주는 것.
            CatRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            jumpCnt++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            jumpCnt = 0;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
