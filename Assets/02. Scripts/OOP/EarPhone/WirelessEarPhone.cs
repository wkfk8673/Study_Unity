using UnityEngine;

public class WirelessEarPhone : MonoBehaviour
{
    public float batterySize;
    public bool isWirelessCharged;

    public void Charged()
    {
        if (isWirelessCharged)
        {
            Debug.Log("무선 충전");
        }
        else
        {
            Debug.Log("유선 충전");
        }
    }
}
