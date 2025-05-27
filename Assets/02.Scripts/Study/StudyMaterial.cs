using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;
    public string hexCode; 

    void Start()
    {
        // this.GetComponent<Material>() = mat; 불가능한 방식, 렌더러 접근이 우선

        // this.GetComponent<MeshRenderer>().material = mat;

        // this.GetComponent<MeshRenderer>().sharedMaterial = mat;

        // 머티리얼 컬러 변경
        // this.GetComponent<MeshRenderer>().material.color = Color.green;


        // 연결된 머티리얼 컬러 전부 변경
        // this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;

        // 컬러를 직접적으로 변경, 마지막 값은 밝은 정도
        // this.GetComponent<MeshRenderer>().material.color = new Color(200f/255f, 137f/255f, 70f/255f, 1);

        // 컬러를 직접적으로 변경, 컬러코드 이용하여 변경
        mat = this.GetComponent<MeshRenderer>().material;
        Color outPutColor;

        if(ColorUtility.TryParseHtmlString(hexCode, out outPutColor))
        {
            mat.color = outPutColor;
        }
    }
}
