using UnityEngine;

public class CatFollow : MonoBehaviour
{
    public Transform cat;
    public Vector3 offset; // 피봇 위치 맞추기 위한 변수
    void Update()
    {
        this.transform.position = cat.transform.position + offset;
    }
}
