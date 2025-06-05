using UnityEngine;

public class Coin : MonoBehaviour
{
    /// 코인을 감지하고 먹음
    /// 충돌 이후 X 감지 이후 ObjectMouseEvent

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Movement.coinCount++;
            Debug.Log($"코인 획득! : {Movement.coinCount}");
            Destroy(gameObject);
        }
    }
}
