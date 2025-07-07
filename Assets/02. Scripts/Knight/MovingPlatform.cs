using System.Timers;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public enum MoveType { Horizontal, vertical }
    public MoveType moveType;

    public float theta;
    public float power;
    public float speed;

    private Vector3 initPos;

    private void Start()
    {
        initPos = transform.position;
    }

    private void Update()
    {
        theta += Time.deltaTime * speed;

        if (moveType == MoveType.Horizontal)
            transform.position = new Vector3(initPos.x + power * Mathf.Sin(theta), initPos.y, initPos.z);
        else if (moveType == MoveType.vertical)
            transform.position = new Vector3(initPos.x, initPos.y + power * Mathf.Sin(theta), initPos.z);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(transform); // other 의 부모를 자기 자신으로 수정
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(null); // other 의 부모를 null 처리하여 원래 구조로 복원

        }
    }
}
