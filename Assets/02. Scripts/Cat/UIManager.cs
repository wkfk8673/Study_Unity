using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace Cat
{
    public class UIManager : MonoBehaviour
    {
        public GameObject playObj;
        public GameObject introUI;


        public TMP_InputField inputField;
        public TextMeshProUGUI nameTextUI; // 컴포넌트

        public Button startButton;

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
                playObj.SetActive(true);
                introUI.SetActive(false);

                Debug.Log($"{nameTextUI.text} 입력");
                // 컴포넌트 하위 텍스트의 값을 변경
                nameTextUI.text = inputField.text;

            }
        }
    }

}
