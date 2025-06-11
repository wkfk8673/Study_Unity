using UnityEngine;

public class Material_LoopMap : MonoBehaviour
{
    private MeshRenderer renderer; //renderer 로 선언할 경우 범위가 더 큼 형변환 관련이라, 추후 설명 예정

    [SerializeField]
    private float offsetSpeed = 0.01f;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        Vector2 offset = Vector2.right * offsetSpeed * Time.deltaTime;
        renderer.material.SetTextureOffset("_MainTex", renderer.material.mainTextureOffset + offset);
    }
}
