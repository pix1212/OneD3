using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Jobs : Oder
{
    public int hp;
    public int damage;
    
    

    public Monster monster;


    void Start()
    {
        
    }
    void Update()
    {
        Attack();

    }

    public void TakeDamage()
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

        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                IDamageable monster = hit.transform.GetComponent<IDamageable>();
                monster?.TakeDamage(damage);
            }
        } 


    }

    //public abstract void Shot();
    












}
