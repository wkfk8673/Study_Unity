using UnityEngine;
using UnityEngine.UI;

public class PinballManager : MonoBehaviour
{
    public Rigidbody2D leftBarRb;
    public Rigidbody2D rightBarRb;
    public int totalScore = 0; // 스코어는 manager 등에서 관리하는 것이 좋은 구조


    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            leftBarRb.AddTorque(30f);
        }
        else
        {
            leftBarRb.AddTorque(-25f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rightBarRb.AddTorque(-30f);
        }
        else
        {
            rightBarRb.AddTorque(25f);
        }
    }
}
