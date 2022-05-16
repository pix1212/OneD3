using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour, IDamageable 
{
    public string name;
    public int hp;
    public int speed;
    public int damage;



    void Start()
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

    void Update()
    {

    }
}
