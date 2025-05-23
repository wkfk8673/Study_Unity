using System;
using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    //멤버 변수 생성
    // 접근 제한자를 별도로 적어주지 않을 경우 private 로 처리됨
    public int[] arrayNumber = new int[5]{1,2,3,4,5}; // 배열 생성 (5개를 만들겠다.)

    // Alt + Enter missing references, nameSpace 추가 (using System.Collections.Generic;)
    public List<int> listNumber = new List<int>();

    int number1 = 1;
    private int number2 = 2;
    public int number3 = 3;

    [SerializeField] //private 필드를 직렬화하기 위해 사용
    private int number4 = 4;

    [SerializeField]
    int number5 = 5;

    void Start()
    {
        // 리스트 값 초기화
        listNumber.Add(1); // list 에 숫자를 추가하는 명령어 (기능), 함수 내부에 선언 필요
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);

        // 첫번째 indexer == 0
        // 두번째 indexer == 1
        // List 내 마지막 데이터를 가리키고 싶을 경우 listNumber.Count - 1 되어야.

        Debug.Log($"현재 List 내 요소 갯수 : {listNumber.Count}");
        Debug.Log($"현재 List 마지막 데이터 : {listNumber[listNumber.Count - 1]}");

        /*foreach (int i in arrayNumber) // foreach 의 i는 배열 내 요소 갯수
        {
            Debug.Log($"Array 의 {i} 번째 값 : {arrayNumber[i-1]}"); // indexer 는 순서, 0부터 시작
        }
        */
    }
}
