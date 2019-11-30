using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierMove : MonoBehaviour
{
    
    float speed = 4;
    Vector3 moveDir = Vector3.zero;
    CharacterController controller;
    Animator animator;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded)
        {
            moveDir = new Vector3(0,0,1);
            moveDir *= speed;
        }
        controller.Move(moveDir * Time.deltaTime);
    }
}
