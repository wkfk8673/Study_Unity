using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Pinball : MonoBehaviour
{
    public PinballManager pinballManager; // 유니티상에서 할당 필요
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Untagged") == false)
        {
            int score = 0; // score 지역변수
            switch (other.gameObject.tag)
            {
                case "Score10":
                    score = 10;
                    break;
                case "Score20":
                    score = 20;
                    break;
                case "Score40":
                    score = 40;
                    break;
            }
            pinballManager.totalScore += score; // totalScore 에 저장

        }
        /*
        if (other.gameObject.CompareTag("Score10"))
        {
            pinballManager.totalScore += 10;
            Debug.Log("10점 획득");
           
        }
        else if (other.gameObject.CompareTag("Score20"))
        {
            pinballManager.totalScore += 20;
            Debug.Log("20점 획득");

        }
        else if (other.gameObject.CompareTag("Score40"))
        {
            pinballManager.totalScore += 40;
            Debug.Log("40점 획득");

        }
        */
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gameover"))
        {
            Debug.Log($"게임종료 : 현재 점수 : {pinballManager.totalScore}");
        }
    }
}
