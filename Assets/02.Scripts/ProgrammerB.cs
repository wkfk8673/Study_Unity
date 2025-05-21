using UnityEngine;
using DevA;

public class ProgrammerB : MonoBehaviour
{
    //클래스를 활용해서 생성된 object
    //유니티에서는 보통 이렇게 생성하지 않음
    //ProgrammerA pA = new ProgrammerA();

    // 같은 scene 에 이미 직렬화 된 상태
    // 그냥 아래와 같이 선언해도 됨
    public ProgrammerA pA;

    private void Start()
    {
        // Programmer A가 직렬화 되어 정상 접근
        pA.number2 = 20;

    }
}
