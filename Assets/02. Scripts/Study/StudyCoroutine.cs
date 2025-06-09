using System.Collections;
using UnityEngine;

public class StudyCoroutine : MonoBehaviour
{
    //private Coroutine runningCoroutine;
    private bool isStop = false;

    private void Start()
    {
        StartCoroutine(BombRoutine());
    }

    IEnumerator BombRoutine()
    {
        int t = 10;
        while (t > 0)
        {
            Debug.Log($"{t}초 남았습니다.");
            yield return new WaitForSeconds(1f);
            t--; 

            if (isStop)
            {
                Debug.Log("폭탄 해제.");
                yield break; // 코루틴 내 브레이크 문은 이런 형태로 작성
            }
        }
        Debug.Log("폭탄 터졌습니다.");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
    }

    /* IEnumerator Start()
     {
         yield return null; // waitSeconds 이용하여 대기 기능을 사용하기도 함
         while (true)
         {
             yield return null; // 한 프레임 대기로, update 문과 동일하게 동작
             Debug.Log("코루틴 실행");
         }
     }
    */


    /*void Start()
    {
        
        //호출 방식
        StartCoroutine("RoutineA"); // O
        StartCoroutine(RoutineA()); // O
        runningCoroutine = StartCoroutine(RoutineA()); // O

        // STOP 방식
        StopCoroutine("RoutineA"); // O
        StopCoroutine(runningCoroutine); // O
        StopAllCoroutines(); // O 코드 상에 있는 모든 코루틴 멈춤
        StopCoroutine(RoutineA()); // X 함수 호출 시 미동작
        

    }*/

    /*
    IEnumerator RoutineA() // 대기를 할 수 있는 기능
    {
        yield return new WaitForSeconds(2f); // 코루틴에서 반드시 사용되는 코드, 지연도 가능
        Debug.Log("첫번째 지연");
        yield return new WaitForSeconds(3f); // 코루틴에서 반드시 사용되는 코드, 지연도 가능
        Debug.Log("두번째 지연");
        yield return new WaitForSeconds(3f); // 코루틴에서 반드시 사용되는 코드, 지연도 가능
        Debug.Log("세번째 지연");
        Debug.Log("코루틴 실행");
    }

    void StopMethod()
    {
        StopCoroutine(RoutineA());
    }
    */


}
