using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMove : MonoBehaviour
{
    
    public float speed = 4;
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    Animator animator;
    Transform ts;

    void Start()
    {
        ts = GetComponent<Transform>();
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ts.position = new Vector3(ts.position.x, 0, ts.position.z);
        if(controller.isGrounded) //controller.isGrounded
        {
            moveDir = new Vector3(0,0,1);
            moveDir *= speed;
        }
        controller.Move(moveDir * Time.deltaTime);
    }
}
