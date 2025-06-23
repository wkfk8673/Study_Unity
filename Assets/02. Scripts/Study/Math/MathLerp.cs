using UnityEngine;

public class MathLerp : MonoBehaviour
{
    public Vector3 target;
    public float smoothValue;

    private Vector3 startPos;
    private float timer, percent;
    public float lerpTime; // 이동에 걸릴 시간

    private void Start()
    {
        startPos = transform.position; //시작지점 저장
    }
    void Update()
    {
        timer += Time.deltaTime; // 시간 조각, Time.time == 유니티 에디터 플레이 후 누적시간
        percent = timer/lerpTime; 

        // 선형 보간, 일정한 속도로 이동
        transform.position = Vector3.Lerp(startPos, target, percent);    
    }
}
