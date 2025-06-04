using UnityEngine;

namespace Cat // 자주 사용할 가능성이 높아 네임 스페이스를 생성함 
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip jumpClip; //외부 cat controller 에서 접근 필요
        public AudioClip bgmClip;

        private void Start()
        {
            SetBgmSound();
        }

        public void SetBgmSound()
        {
            audioSource.clip = bgmClip; // audioSource 상에 clip 에 bgmClip 할당
            audioSource.playOnAwake = true;
            audioSource.loop = true;
            audioSource.volume = 0.1f;

            audioSource.Play();
        }
        public void OnJumpSound() //외부 프로그램에 의해 실행 되는 경우 On 을 붙이는 경우가 많음
        {
            audioSource.PlayOneShot(jumpClip); // 할당 없이 사용, PlayOneShot 은 일종의 인스턴스 같은느낌 BGM에 영향 X, 이벤트 사운드.
                                               // 멈추거나 종료하는 등의 제어 불가
        }
    }
}
