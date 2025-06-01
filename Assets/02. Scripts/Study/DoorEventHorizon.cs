using UnityEngine;

public class DoorEventHorizon : MonoBehaviour
{
    private Animator anim;
    public string openKey;
    public string closeKey;

    private void Start()
    {
        // 본인이 들고 있는 애니메이터 컴포넌트를 할당하겠다.
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Trigger 명칭을 변경
            anim.SetTrigger(openKey);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Trigger 명칭을 변경
            anim.SetTrigger(closeKey);
        }
    }
}
