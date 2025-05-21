using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    // GameObject 데이터 타입
    //public GameObject objCube; // 큐브 게임 오브젝트를 넣을 것.
    // 직접 넣지 않아도 되는 오브젝트면 굳이 public 으로 오브젝트를 불러와 넣을 이유가 없다.
    // find 기능을 사용하면 됨 .
    
    private GameObject objCube;

    public string changeName; 

    private void Start()
    {
        objCube = GameObject.Find("Main Camera");
        objCube.name = changeName;
    }
}
