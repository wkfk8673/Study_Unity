using System.Collections;
using Cat;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.Video;

public class CatController : MonoBehaviour
{
    public SoundManager soundManager; // 개체 참조
    public VideoManager videoManager;

    public GameObject gameOverUI;
    public GameObject FadeUI;

    private Rigidbody2D CatRb; // cat
    private Animator catAnim;

    public float jumpPower = 10f;
    private float limitPower = 10f;

    private int jumpCnt = 0;

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

    /// <summary>
    /// 2단 점프까지 가능한 CatJump
    /// </summary>
    private void catJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCnt < 10)
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

    /// <summary>
    /// 사과와 부딪혔을 경우 점수 증가
    /// 10 점 달성 시 게임 종료
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            GameManager.score++;
            other.gameObject.SetActive(false); // 부딪힌 사과 비활성화
            other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(true); //부모 오브젝트 스크립트 접근 후 파티클 활성화
            if (GameManager.score == 10) // 사과 10개 획득 후 게임 종료
            {
                FadeUI.SetActive(true);
                FadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.white);
                this.GetComponent<CircleCollider2D>().enabled = false;

                //Invoke("HappyVideoPlay", 5f); 코루틴으로 대체
                StartCoroutine(EndingRoutine(true));
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            soundManager.OnColliderSound(); // 사운드 매니저 내 충돌 효과음

            gameOverUI.SetActive(true);
            FadeUI.SetActive(true);
            FadeUI.GetComponent<FadeRoutine>().OnFade(3f, Color.black);

            this.GetComponent<CircleCollider2D>().enabled = false;
            //Invoke("UnHappyVideoPlay", 5f); 코루틴으로 대체
            StartCoroutine(EndingRoutine(false));
        }
        if (collision.gameObject.CompareTag("Ground"))
        {
            catAnim.SetBool("Ground", true);

            jumpCnt = 0;
        }
    }

    /// <summary>
    /// 비디오 실행 및 기존 Ui 와 사운드를 중지시키는 함수
    /// 매개변수 활용을 통해 코드 단순화, 지연을 위한 Invoke 사용불가 -> 코루틴 사용 )
    /// </summary>

    IEnumerator EndingRoutine(bool isHappy)
    {
        yield return new WaitForSeconds(3.5f);
        videoManager.VideoPlay(isHappy); // 영상 실행 시 약간 밀리는 현상

        yield return new WaitUntil(() => videoManager.vPlayer.isPlaying); // vPlayer 에서 실행중인지 여부 판단 bool 타입
        // 잔여 UI off 처리
        FadeUI.SetActive(false);
        gameOverUI.SetActive(false);
        soundManager.audioSource.mute = true;
    }

    /*
    public void HappyVideoPlay()
    {

        videoManager.VideoPlay(true);
        FadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }

    public void UnHappyVideoPlay()
    {
        videoManager.VideoPlay(false);
        FadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }
    */
}
