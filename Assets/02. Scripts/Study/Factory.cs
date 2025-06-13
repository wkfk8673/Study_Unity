using UnityEngine;

public class Factory<T> : MonoBehaviour
{
    public T instance;

    public Factory()
    {
        Debug.Log($"Factory 는 {typeof(T)} 타입입니다."); // 런타임이 아닌 컴파일 타임에서 <T> 를 결정 (타입)
    }

}
