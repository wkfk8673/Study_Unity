using UnityEngine;

public class ObjectMouseEvent : MonoBehaviour
{
    /// <summary>
    /// 실행 순서에 따른 정렬
    /// </summary>
    private void OnMouseEnter()
    {
        Debug.Log("Mouse Enter");
    }
    private void OnMouseOver()
    {
        Debug.Log("Mouse Over");
        
    }
    private void OnMouseDown()
    {
        Debug.Log("Mouse Down");
    }
    private void OnMouseDrag()
    {
        Debug.Log(Input.mousePosition);
        Debug.Log("Mouse Drag");
    }

    private void OnMouseUp()
    {
        Debug.Log("Mouse Up");
    }


    private void OnMouseUpAsButton()
    {
        Debug.Log("Mouse UpAsButton");
    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse Exit");
    }

}
