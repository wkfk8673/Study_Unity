using UnityEngine;

public class colliderEvent : MonoBehaviour
{
    public GameObject FadeOut;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("GameOver");
            FadeOut.SetActive(true); // 임시 세팅

        }
    }
}
