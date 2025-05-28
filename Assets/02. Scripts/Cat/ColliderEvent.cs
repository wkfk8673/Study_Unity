using UnityEngine;

public class colliderEvent : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("GameOver");

        }
    }
}
