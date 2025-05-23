using UnityEngine;

/// <summary>
/// LookAt 의 기능을 살펴보자
/// LookAt 은 Transform 내부에 있는 항목, 이 경우 gameObject 보다 Transform 을 선언하는 편이 약간 더 효율적
/// </summary>
public class StudyLookAt : MonoBehaviour
{
    public Transform targetTF; // 바라볼 대상
    public Transform turretHead; // 대포

    public GameObject bulletPrefab; // 총알 프리팹 
    public Transform firePos; // 발사 위치

    public float timer;
    public float coolDownTime = 100f;

    private void Start() // 1번 실행, 정보 세팅
    {
        targetTF = GameObject.FindGameObjectWithTag("Player").transform;        
    }
    void Update() // 연속 실행, 무언가를 바라보는 기능
    {
        turretHead.LookAt(targetTF);
        timer += Time.deltaTime;
        if(timer >= coolDownTime) // 딜레이 추가
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation); // 프레임 단위로 생성됨
        }
        
    }
}
