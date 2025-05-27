using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    /// <summary>
    /// 태양계를 뱅글뱅글 도는 모델을 생성
    /// </summary>
    

    public Transform targetPlanet;

    public float rotSpeed = 30f; // 자전 속도
    public float revolutionSpeed = 100f; // 공전 속도

    public bool isRevolution = false;

    void Update()
    {
        // 자기 자신이 회전하는 기능
        // Vector.up (Y 축을 기준으로 돌겠다는 의미)
        
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);


        if(isRevolution == true) // 공전을 한다면
        {
            // targetPlanet 을 y축으로 기준 삼아 돌겠다는 의미.
            transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime); 
        }
        
    }
}
