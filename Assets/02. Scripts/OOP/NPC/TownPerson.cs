using UnityEngine;

public class TownPerson : Npc, IMove, ITalk
{

    public void Move()
    {
        Debug.Log("Move");
    }

    public void Talk()
    {
        Debug.Log("Talk");
    }
}
