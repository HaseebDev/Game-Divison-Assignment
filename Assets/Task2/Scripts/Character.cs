using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    public float health;
    public Weapon weapon;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        //Die
    }
}