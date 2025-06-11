using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class RemoteController : MonoBehaviour
{
    public GameObject videoScreen;
    public bool isOn = false;
    public bool isMute = false;

    //추가, 삭제 및 변경 가능성 없는 상황이라 배열로 선언
    public Button[] buttonUI;
    public VideoClip[] videoClips;

    private VideoPlayer videoPlayer;

    public int currClipIndex = 0;


    private void Awake()
    {
        // 스크립트에서 직접 할당
        videoPlayer = videoScreen.GetComponent<VideoPlayer>();
        videoPlayer.clip = videoClips[0];
    }

    private void Start()
    {
        //onClick 이벤트 할당
        buttonUI[0].onClick.AddListener(OnScreenPower);
        buttonUI[1].onClick.AddListener(OnMute);
        buttonUI[2].onClick.AddListener(() => OnChangeChannel(false)); // 람다식을 사용하여 인수가 있는 값을 OnClick 이벤트에 할당
        buttonUI[3].onClick.AddListener(() => OnChangeChannel(true));
    }

    public void OnScreenPower()
    {
        //게임 오브젝트 속성을 활용한 방식
        videoScreen.SetActive(!videoScreen.activeSelf);
        /*
        // NOT을 활용하여 줄여서 적은 방법
        // isOn = !isOn;
        // videoScreen.SetActive(isOn);

        // 길게 적은 방법
        // if (!isOn) // isOn == false
        // {
        //     videoScreen.SetActive(true);
        //     isOn = true; // 현재 티비 On
        // }
        // else // isOn == true
        // {
        //     videoScreen.SetActive(false);
        //     isOn = false;
        // }
        */
    }

    public void OnMute()
    {
        isMute = !isMute; // T/F 전환
        videoPlayer.SetDirectAudioMute(0, isMute); // 영상 소리 음소거, volume 0 으로 변경하는 것도 가능

    }

    public void OnChangeChannel(bool isNext)
    {
        if (isNext)
        {
            currClipIndex++;
            if (currClipIndex >= videoClips.Length)
            {
                currClipIndex = 0;
            }
        }
        else 
        { 
            currClipIndex--;

            if (currClipIndex < 0)
            {
                currClipIndex = videoClips.Length - 1;
            }
        }

        // 클립변경 후 재생
        videoPlayer.clip = videoClips[currClipIndex];
        videoPlayer.Play();
    }



}
