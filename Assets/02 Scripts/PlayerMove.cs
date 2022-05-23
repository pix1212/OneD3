using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    float hAxis;
    float vAxis;

    Vector3 moveVec;

    Animator anim;
    void Start()
    {
        
    }
 
    void Update()
    {
        GetInput();
        Move();
        Turn();
    }

    void GetInput()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");

    }

    void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;

        transform.position += moveVec *speed * Time.deltaTime;
    }

    void Turn()
    {
        transform.LookAt(transform.position + moveVec);
    }

}
