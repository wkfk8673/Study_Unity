using UnityEngine;
using UnityEngine.Video;

namespace Cat
{
    /// <summary>
    /// render texture ui 사용하여 비디오 최상단 재생
    /// </summary>
    public class VideoManager : MonoBehaviour
    {      
        public VideoPlayer vPlayer;
        public GameObject vPanel;
        public VideoClip[] vClips;

        private void Start()
        {
            // 자기 자신의 컴포넌트 할당
            vPlayer = GetComponent<VideoPlayer>();
        }

        public void VideoPlay(bool isHappy)
        {
            vPanel.SetActive(true);

            var endingClip  = isHappy ? vClips[0] : vClips[1]; //isHappy 조건에 따라 var clip 에 vClips 할당
            vPlayer.clip = endingClip; // var clip 에 저장된 사항을 vPlayer 에 할당
            vPlayer.Play(); // 재생
        }
    }

}
