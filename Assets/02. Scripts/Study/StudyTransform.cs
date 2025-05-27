using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    void Update()
    {
        // 월드 방향으로 이동하는 기능
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬 방향으로 이동하는 기능
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);


        // 월드 방향을 기준으로 Y축 회전 (0, y, 0)
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        // 로컬 방향으로 회전 (자기 자신을 기준으로)
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime); // Space.Self 생략

        // 특정 위치를 중심으로 y축 방향 회전하는 기능
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);

        // 게임 오브젝트가 월드 상의 특정 위치를 바라 보도록 만드는 기능
        transform.LookAt(Vector3.up);
    }
}