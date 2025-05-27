using UnityEngine;

public class StudyMath : MonoBehaviour
{
    /// <summary>
    /// 기본 게임 수학
    /// </summary>
    void Start()
    {
        //각도(Degree) > 라디안(Radian) 변환
        //Mathf.Deg2Rad

        //라디안(Radian) > 각도(degree) 변환
        //Mathf.Rad2Deg

        // degree 이용 시 3D환경에서 400도에 대한 처리, 350 도에 대한 처리가 이상해질 수 있음
        float degree = 180f;
        
        // 따라서 아래와 같이 라디안 변환을 해주어야한다.
        float rad = degree * Mathf.Deg2Rad;

        Debug.Log(rad);
    }

}
