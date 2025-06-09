using UnityEngine;

public class StudyRandom : MonoBehaviour
{
    private void OnEnable()
    {
        //int ranNumber = Random.Range(0, 100); // 100 미포함
        float ranNumber = Random.Range(0f, 100f); // 100 포함
        Debug.Log(ranNumber);
    }
}
