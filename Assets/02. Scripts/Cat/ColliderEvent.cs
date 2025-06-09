using System.Collections;
using UnityEngine;

public class colliderEvent : MonoBehaviour
{
    public GameObject play;
    public Animator Fade;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("GameOver");
            StartCoroutine(Gameover());
        }
    }

    IEnumerator Gameover()
    {
        Fade.SetTrigger("GameOver");
        play.SetActive(false);
        yield return new WaitForSeconds(1f);
    }
}
