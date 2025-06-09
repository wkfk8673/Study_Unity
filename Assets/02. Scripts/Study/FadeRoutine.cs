using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class FadeRoutine : MonoBehaviour
{
    public Image fadePanel; // 페이드 이미지
    public bool selectFadeIn = false;
    

    private void Start()
    {
        //StartCoroutine(FadeOutCoroutine(3));
        StartCoroutine(FadeCoroutine(3f, selectFadeIn)); //
    }


    private IEnumerator FadeCoroutine(float fadeTime, bool isFadeIn) // 1회 실행
    {
        float timer = 0f; // 사용될 타이머
        float percent = 0f; // 페이드 진행 정도


        float value = 0; 

        while (percent < 1f)
        {
            timer += Time.deltaTime; // 타이머 활용
            percent = timer / fadeTime;
            value = isFadeIn ? 1 - percent : percent;

            fadePanel.color = new Color(fadePanel.color.r, fadePanel.color.g, fadePanel.color.b, value);
            yield return null;
        }
    }
}
