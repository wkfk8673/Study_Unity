using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, destroyTime); // 자기 자신을 3초 뒤에 파괴하는 기능
    }

    private void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다."); 
    }
}
