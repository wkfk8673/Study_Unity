using UnityEngine;

public class MouseEvent : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Button Down");
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse Button");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse Button Up");
        }
    }
}
