using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target; // 카메라가 따라갈 대상
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothSpeed;

    [SerializeField] private Vector2 minBound;
    [SerializeField] private Vector2 maxBound;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform; // "Player" 태그를 가진 게임 오브젝트 위치 받아옴
    }
    void LateUpdate() // LateUpdate는 update 에 포함된 캐릭터 이동이 끝난 후 호출되어 카메라 위치를 업데이트
    {
        Vector3 destination = target.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, destination, Time.deltaTime * smoothSpeed); //속도 및 보간을 적용한 위치 정보 저장

        smoothPos.x = Mathf.Clamp(smoothPos.x, minBound.x, maxBound.x); // 카메라의 x 위치를 제한
        smoothPos.y = Mathf.Clamp(smoothPos.y, minBound.y, maxBound.y); // 카메라의 y 위치를 제한

        transform.position = smoothPos; // 카메라 위치 업데이트
    }
}
