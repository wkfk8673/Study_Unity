using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour
{
    public GameObject portalEffect;
    public GameObject loadingImage;
    public FadeRoutine fade;

    public Image progressBar;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(PortalRoutine()); // 캐릭터가 닿았을 경우 실행
        }
    }

    IEnumerator PortalRoutine()
    {
        portalEffect.SetActive(true);
        yield return StartCoroutine(fade.Fade(1f, Color.white, true)); // fade 코루틴 종료 시 까지 대기

        // 로딩 이미지 전환
        loadingImage.SetActive(true);
        yield return StartCoroutine(fade.Fade(1f, Color.white, false)); // fade 코루틴 종료 시 까지 대기

        while(progressBar.fillAmount < 1f)
        {
            progressBar.fillAmount += Time.deltaTime * 0.3f; // 3초 정도 소요 되도록 감소 시킴
            yield return null;
        }

        // 코루틴 종료 후 씬 변경
        SceneManager.LoadScene(1);
    }
}
