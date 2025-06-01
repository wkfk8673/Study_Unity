using UnityEngine;

public class DoorEvent : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>(); // 자기 자신의 애니메이터 할당
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //Collision 의 경우 상위 개념, gameObject 입력하지 않을 경우 미동작
        {
            animator.SetTrigger("Open");
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Collider 는 동일 컴포넌트 개념, 
        {
            animator.SetTrigger("Close");
        }
    }
}
