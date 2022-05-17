using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Oder
{
    public int hp;
    protected int damage;

    bool isEnemyDead = false;

    void Start()
    {
        
    }

    void Update()
    {
        Attack();
    }


    public void TakeDamage(int damage)
    {
        hp -= damage;

        if(hp <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }

    void Attack()
    {
        damage = Random.Range(5,9);

        //character?.TakeDamage(damage);
    }

    
}
