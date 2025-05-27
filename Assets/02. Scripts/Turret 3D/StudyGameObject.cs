using UnityEngine;
using static UnityEditor.PlayerSettings;
using static UnityEngine.Rendering.DebugUI.Table;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    //public Vector3 pos;
    //public Quaternion rot;

    // 시스템의 주축이되는 내용 세팅 시 awake 사용
    // start 에 서브 요소 세팅
    private void Awake()
    {
        Debug.Log("어몽어스 캐릭터 생성");
        CreateAmongus();
        // Destroy(destroyObj, 3f); // 매개 변수로 들어간 게임오브젝트를 파괴하는 기능

    }

    /// <summary>
    /// 프리펩을 이용해 어몽어스 캐릭터 생성
    /// 이후 이름을 변경하는 기능
    /// </summary>
    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab); // 게임 오브젝트 생성 기능, 이름은 prefab(Clone) 형태로 생성함
        obj.name = "어몽어스 캐릭터"; // 이름값 초기화

        Debug.Log($"캐릭터의 자식 오브젝트 수 : {obj.transform.childCount}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트 : {obj.transform.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트 : {obj.transform.GetChild(obj.transform.childCount-1).name}");
        /*
        public GameObject destroyObj;

        private void OnDestroy() // 유니티 프로그램을 종료했을때 발생.
        {
            Debug.Log($"파괴되었습니다.");// 스크립트가 붙어있는 객체가 파괴 되어야 이 이벤트가 발생하기 때문
        }
        */
    }
}