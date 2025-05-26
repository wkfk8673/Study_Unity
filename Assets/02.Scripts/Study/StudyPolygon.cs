using UnityEngine;

public class StudyPolygon : MonoBehaviour
{
    
    void Start()
    {
        Mesh mesh = new Mesh(); // 형태 데이터가 들어갈 mesh 타입의 변수 생성
        Vector3[] vertices = new Vector3[] // 3차원 공간에 4개의 점 찍기
        {
            new Vector3(0,0,0),
            new Vector3(1,0,0),
            new Vector3(0,1,0),
            new Vector3(1,1,0)
        };

        int[] triangles = new int[]
        {
            0,2,1,
            2,3,1
        };

        Vector2[] uv = new Vector2[] // UV는 기본적으로 3D모델링의 '전개도', 면의 방향이 중요함
        {
            new Vector2(0,0),
            new Vector2(1,0),
            new Vector2(0,1),
            new Vector2(1,1)
        };

        // Mesh 에 위에서 만든 정점, 삼각형 그릴 순서, uv 데이터 적용
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uv;

        // MeshFilter 에 Mesh 데이터를 적용
        MeshFilter meshFilter = this.gameObject.AddComponent<MeshFilter>(); //visual Scripting 미사용
        meshFilter.mesh = mesh;

        //MeshRenderer에 Material 데이터를 적용
        MeshRenderer meshRenderer = this.gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = new Material(Shader.Find("Sprites/Default"));
    }
}
