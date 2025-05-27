using UnityEngine;

public class StudyOperator : MonoBehaviour
{
    public int currentLevel = 10;
    public int maxLevel = 99;

    void Start()
    {
        bool isMax = currentLevel >= maxLevel;
        string msg = currentLevel >= maxLevel ? "현재 만렙입니다." : "현재 만렙이 아닙니다.";

        int levelPoint = currentLevel >= maxLevel ? 0 : 1;
        currentLevel += levelPoint;

        int count = 0;
        while (count < 10)
        {
            count = count + 1;
        }
        for(int i = 0; i < 5; i++)
        {
            count = count - 1;
        }
        Debug.Log($"count : {count}");

    }
}
