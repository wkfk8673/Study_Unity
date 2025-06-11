using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Cat
{
    public class GameManager : MonoBehaviour
    {
        public SoundManager soundManager;
        public TextMeshProUGUI playTimeUI;
        public TextMeshProUGUI ScoreUI;

        private float timer;
        public static int score; // 사과를 먹은 갯수, 타 클래스에서 접근 가능하도록 static 선언
        public static bool isPlay = false;

        private void Start()
        {
            soundManager.SetBgmSound("Intro");

        }

        private void Update()
        {
            if (!isPlay) return; // play 상태가 아닐 경우 Update 문 종료

            timer += Time.deltaTime;
            playTimeUI.text = $"{timer:F1}";
            ScoreUI.text = $"X {score}";

        }
    }
}

