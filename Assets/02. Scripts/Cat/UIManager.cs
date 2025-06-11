using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public SoundManager soundManager;

        public GameObject playObj;
        public GameObject introUI;
        public GameObject playUI;


        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI; // 컴포넌트

        public Button startButton;


        private void Awake()
        {
            // Scene 세팅, 보통 gameManager 에서 사용하는 것이 맞음. 
            playObj.SetActive(false);
            introUI.SetActive(true);
            playUI.SetActive(false);
        }
        private void Start()
        {
            // start 버튼 접근 후 클릭 이벤트에서 OnStartButton() 이벤트 호출
            startButton.onClick.AddListener(OnStartButton);
        }

        public void OnStartButton()
        {
            bool isNoText = inputField.text == "";

            if (isNoText) // 닉네임 미작성
            {
                startButton.interactable = false;
                Debug.Log("입력 텍스트 없음");
            }
            else
            {
                // 컴포넌트 하위 텍스트의 값을 변경
                nameTextUI.text = inputField.text;
                Debug.Log($"{nameTextUI.text} 입력");

                // Get Ready 이후의 동작
                soundManager.SetBgmSound("Play");

                GameManager.isPlay = true; // intro 와 play 씬 간 연결

                introUI.SetActive(false);
                playObj.SetActive(true);
                playUI.SetActive(true);
            }
            startButton.interactable = true;
        }
    }

}
