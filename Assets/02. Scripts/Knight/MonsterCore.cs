using UnityEngine;

public class MonsterCore : MonoBehaviour
{
    /// 여러 상태 나열이 필요하므로 enum 필요 (열거형)
    public enum MonsterState { IDLE, PATROL, TRACE, ATTACK }
    public MonsterState monsterState = MonsterState.PATROL; // 기본 설정

    private void Update()
    {
        switch (monsterState)
        {
            case MonsterState.IDLE:
                break;
            case MonsterState.PATROL:
                break;
            case MonsterState.TRACE:
                break;
            case MonsterState.ATTACK:
                break;
        }
    }
}
