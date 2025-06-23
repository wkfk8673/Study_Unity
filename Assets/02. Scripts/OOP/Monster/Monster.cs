using UnityEngine;

public abstract class Monster : Character, IDamageable
{
    public float hp = 10f;
    public abstract void SetHealth();

    public void TakeDamage(float damage)
    {
        Debug.Log($"{damage}만큼의 피해를 입었습니다.");

        hp -= damage;
        if (hp <= 0f)
            Death();
    }

    public void Death()
    {
        Debug.Log("문이 파괴되었습니다.");
    }
}
