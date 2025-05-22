using UnityEngine;
using UnityEngine.UIElements; // unityEngine 이라는 네임스페이스 활용

// 접근제한자 클래스명 : 유니티 유용한 기능이 들어있는 곳에서 상속
public class StudyComponent : MonoBehaviour
{
    // GameObject 데이터 타입
    public GameObject objCube; // 큐브 게임 오브젝트를 넣을 것.
    // 직접 넣지 않아도 되는 오브젝트면 굳이 public 으로 오브젝트를 불러와 넣을 이유가 없다.
    // find 기능을 사용하면 됨 .
    // 실제 업무에서는 find 사용하지 않음 (비효율적)

    // 멤버변수, 필드(field)라고 하기도 함
    public GameObject obj;
    public Transform objTF;

    public Mesh userSelectedMesh;
    public Material mat;

    private void Start()


    {
        // 동일 파일명이 3개 있을 경우 마지막에 생성된 항목을 불러옴. 
        objCube = GameObject.Find("Maisn Camera"); // 불안정한 기능

        obj = GameObject.FindGameObjectWithTag("Player"); // 태그를 활용한 find, 못찾으면 null, 이쪽이 좀 더 효율적

        objTF = GameObject.FindGameObjectWithTag("Player").transform; // return 값이 obj.transform 형태

        //objTF.gameObject.SetActive(false); // obj == objTF.gameObject 임 둘이 동일한 걸 가리키고 있기 때문에 이렇게 동작 가능

        
        Debug.Log($"<color=#00FF00>이름 : {obj.name}"); // 게임오브젝트의 이름
        Debug.Log($"태그 : {obj.tag}"); // 게임오브젝트의 태그
        Debug.Log($"위치 : {obj.transform.position}"); // 게임오브젝트의 Transform 컴포넌트의 위치
        Debug.Log($"회전 : {obj.transform.rotation}"); // 게임오브젝트의 Transform 컴포넌트의 회전
        Debug.Log($"크기 : {obj.transform.localScale}"); // 게임오브젝트의 Transform 컴포넌트의 크기

        // MeshFilter 컴포넌트에 접근해서 mesh를 Log로 출력
        Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");

        // MeshRenderer 컴포넌트에 접근해서 material를 Log로 출력
        Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");

        // MeshRenderer 컴포넌트 비활성화
        obj.GetComponent<MeshRenderer>().enabled = false;

        // 게임 오브젝트가 유니티 scene 에 존재하기 위한 필수 데이터 :: transform
        // 따라서 transform 은 필수 요소다보니 GetComponent 를 사용하지 않아도 됨

        

        obj = GameObject.CreatePrimitive(PrimitiveType.Cube); // 잘 사용하지 않는 편
        CreateCube();
        CreateCube("Hello World");

    }

    public void CreateCube(string name = "Cube") // 디폴트 값을 지정
    {
        obj = new GameObject(name); //빈 게임 오브젝트 생성

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = userSelectedMesh; // 컴포넌트에 접근하여 저장

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat; // 컴포넌트에 접근하여 저장

        obj.AddComponent<BoxCollider>();
    }
}

