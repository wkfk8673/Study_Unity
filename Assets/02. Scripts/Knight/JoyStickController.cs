using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStickController : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    [SerializeField] private KnightController_Joy knightController;
    [SerializeField] private GameObject backgroundUI;
    [SerializeField] private GameObject handlerUI;

    private Vector2 startPos, currPos;

    void Start()
    {
        backgroundUI.SetActive(false);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        backgroundUI.SetActive(true);
        backgroundUI.transform.position = eventData.position; // 처음 클릭한 위치로 백그라운드 UI 위치 설정
        startPos = eventData.position; // 시작 위치 저장
    }

    public void OnDrag(PointerEventData eventData)
    {
        currPos = eventData.position;
        Vector2 dragDir = currPos - startPos; // 드래그 방향 계산

        float maxDist = Mathf.Min(dragDir.magnitude, 100f); // Drag 거리 계산, 최대 거리를 100f로 설정

        handlerUI.transform.position = startPos + dragDir.normalized * maxDist; // 방향벡터와 최대거리 제한을 이용해 핸들러 UI 위치 설정
        knightController.InputJoyStick(dragDir.x, dragDir.y); // 조이스틱 입력으로 x, y 값 전달
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        knightController.InputJoyStick(0,0); // 조이스틱 입력을 0으로 초기화
        handlerUI.transform.localPosition = Vector2.zero; // 핸들러 UI를 백그라운드 ui의 원점으로 초기화
        backgroundUI.SetActive(false);
    }

}