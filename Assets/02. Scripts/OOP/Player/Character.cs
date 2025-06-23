using UnityEngine;

public class Character : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flash"))
        {

        }
        else if (other.CompareTag("Gun"))
        {

        }
        else if (other.CompareTag("Key"))
        {

        }
    }
}
