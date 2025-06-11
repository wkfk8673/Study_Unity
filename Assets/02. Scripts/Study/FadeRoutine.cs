using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class FadeRoutine : MonoBehaviour
{
    public Image fadePanel; // 페이드 이미지
    
    public void OnFade(float fadeTime, Color color)
    {
        StartCoroutine(OutroFade(fadeTime, color));
    }

    private IEnumerator OutroFade(float fadeTime, Color color) // 1회 실행
    {
        float timer = 0f; // 사용될 타이머
        float percent = 0f; // 페이드 진행 정도
        while (percent < 1f)
        {
            timer += Time.deltaTime; // 타이머 활용
            percent = timer / fadeTime;
            
            fadePanel.color = new Color(color.r, color.g, color.b, percent);
            yield return null;
        }
    }
}
