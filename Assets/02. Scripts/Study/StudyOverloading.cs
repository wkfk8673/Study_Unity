using System;
using UnityEngine;

public class StudyOverloading : MonoBehaviour
{
    private void Start()
    {
        Attack();
        Attack(true);
        Attack(10f);
        Attack(10f);

        GameObject monsterObj = new GameObject("몬스터");

        Attack(10, monsterObj);

    }

    public void Attack()
    {
        
    }

    public void Attack(bool isMagic)
    {
        if (isMagic)
            Debug.Log("마법공격");
        
    }
    public void Attack(float damage)
    {
        Debug.Log($"{damage} 만큼의 공격");
    }

    public void Attack(float damage, GameObject Target)
    {
        Debug.Log($"{Target} 에게 {damage} 만큼의 공격");
    }
}
