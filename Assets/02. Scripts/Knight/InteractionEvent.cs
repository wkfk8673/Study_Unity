using System.Collections;
using Mono.Cecil;
using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    public enum InteractionType { SIGN, DOOR, NPC }
    public InteractionType type; // 상호작용 타입

    public GameObject Popup;
    public GameObject map;
    public GameObject house;
    public GameObject player;

    public FadeRoutine fade; // 스크립트 접근

    public Vector3 inDoorPos;
    public Vector3 outDoorPos;

    public bool isHouse = false;
    public SoundController SoundController;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Interaction(other.transform);
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Popup.SetActive(false);
        }
    }

    private void Interaction(Transform player)
    {
        switch (type)
        {
            case InteractionType.SIGN:
                Popup.SetActive(true);
                break;
            case InteractionType.DOOR:
                StartCoroutine(DoorRoutine());
                break;
            case InteractionType.NPC:
                Popup.SetActive(true);
                break;
        }
    }

    IEnumerator DoorRoutine()
    {
        SoundController.EventSoundPlay("DoorOpenSFX");
        yield return StartCoroutine(fade.Fade(3f, Color.black, true)); // fade 에 있는 Fade 코루틴으로 접근, 코루틴 종료 이후 시작;


        map.SetActive(isHouse);
        house.SetActive(!isHouse);

        player.transform.position = isHouse ? outDoorPos : inDoorPos;

        isHouse = !isHouse; // 현재 상태 전환

        SoundController.EventSoundPlay("DoorCloseSFX");

        yield return new WaitForSeconds(1f); // 카메라 팔로우 대기
        yield return StartCoroutine(fade.Fade(3f, Color.black, false)); // fade 에 있는 Fade 코루틴으로 접근, 코루틴 종료 이후 시작;
        
    }
}
