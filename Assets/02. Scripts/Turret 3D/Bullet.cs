using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f;
     void Update()
    {
        this.transform.position += this.transform.forward * bulletSpeed * Time.deltaTime;
    }
}
