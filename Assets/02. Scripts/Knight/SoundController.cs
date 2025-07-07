using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundController : MonoBehaviour
{
    [SerializeField] private AudioSource BGM;
    [SerializeField] private AudioSource SFX;
    [SerializeField] private AudioClip[] clips; // 여러가지 오디오 클립 사용 예정, 배열로 이용

    [SerializeField] private Slider bgmVolume;
    [SerializeField] private Toggle bgmMute;

    [SerializeField] private Slider sfxVolume;
    [SerializeField] private Toggle sfxMute;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //LoadScene 이용하여 씬 전환 시에 이 오브젝트를 파괴하지 않도록 선언
        // 현재 설정 값으로 초기화
        bgmVolume.value = BGM.volume;
        sfxVolume.value = SFX.volume;
        
        bgmMute.isOn = BGM.mute;
        sfxMute.isOn = SFX.mute;
    }

    void Start()
    {
        BgmSoundPlay("TownBGM");
        bgmVolume.onValueChanged.AddListener(OnBgmVolumeChanged);
        sfxVolume.onValueChanged.AddListener(OnSfxVolumeChanged);

        bgmMute.onValueChanged.AddListener(OnBgmMute);
        sfxMute.onValueChanged.AddListener(OnSfxMute);
    }

    public void BgmSoundPlay(string ClipName)
    {
        foreach (var clip in clips)
        {
            if (clip.name == ClipName)
            {
                BGM.clip = clip;
                BGM.Play();
            }
        }


    }

    public void EventSoundPlay(string ClipName)
    {
        foreach (var clip in clips)
        {
            if (clip.name == ClipName)
            {
                SFX.PlayOneShot(clip, 1f);
                return; //반환 이후 해당 함수 종료, void 타입이므로 리턴해 줄 값은 없음
            }
        }
        Debug.Log($"{ClipName}을 찾지 못했습니다.");
    }


    private void OnBgmVolumeChanged(float volume)
    {
        BGM.volume = volume;
        // 볼륨이 0에 가까워져, 사실상 뮤트일 경우 전환
        if (volume <= 0.001f)
        {
            bgmMute.isOn = true;
        }
        else
        {
            bgmMute.isOn = false;
        }
    }
    private void OnSfxVolumeChanged(float volume)
    {
        SFX.volume = volume;
        // 볼륨이 0에 가까워져, 사실상 뮤트일 경우 전환
        if (volume <= 0.001f)
        {
            sfxMute.isOn = true;
        }
        else
        {
            sfxMute.isOn = false;
        }
    }

    private void OnBgmMute(bool isMute)
    {
        BGM.mute = isMute;
    }

    private void OnSfxMute(bool isMute)
    {
        SFX.mute = isMute;
    }
}
