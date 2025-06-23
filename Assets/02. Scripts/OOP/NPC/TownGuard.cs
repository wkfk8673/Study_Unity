using UnityEngine;

public class TownGuard : Npc, IMove, IAttack
{

    public void Move()
    {
        Debug.Log("Move");
    }
    public void Attack()
    {
        Debug.Log("Attack");
    }
}
