using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    /// <summary>
    /// 이동하는 파이프와 사과 타일링
    /// </summary>
    
    public enum ColliderType {PIPE,APPLE,BOTH}
    public ColliderType colliderType;

    public GameObject pipe;
    public GameObject apple;
    public GameObject particle; 

    public float moveSpeed = 3f;
    public float returnPosX = 20f;
    private float randomPosY;

    private Vector3 initPos; // 최초 파이프 위치값을 저장

    private void Awake()
    {
        initPos = transform.localPosition; // 최초 1회 저장
    }

    private void OnEnable()
    {
        SetRandomSetting(initPos.x);
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.fixedDeltaTime; // 배경을 왼쪽으로 이동시키는 기능

        if (transform.position.x <= -returnPosX) // 오브젝트가 카메라 영역을 빠져나갔을 경우 (x 축 -30)
        {
            SetRandomSetting(returnPosX);
        }
    }

    private void SetRandomSetting(float posX)
    {
        randomPosY = Random.Range(-8f, -3.5f);
        transform.position = new Vector3(posX, randomPosY, 0); // retunsPos 로 초기화

        // 오브젝트들 모두 비활성화 하여 초기화
        pipe.SetActive(false);
        apple.SetActive(false);
        particle.SetActive(false);

        colliderType = (ColliderType) Random.Range(0, 3); // Random.range 의 값을 명시적 형변환
        //0,1,2 값을 이용하여 colliderType 호출 >> switch case 문을 실행
        switch (colliderType)
        {
            case ColliderType.PIPE:
                pipe.SetActive(true);
                break;
            case ColliderType.APPLE:
                apple.SetActive(true);
                break;
            case ColliderType.BOTH:
                pipe.SetActive(true);
                apple.SetActive(true);
                break;
            default:
                break;
        }
    }
}
