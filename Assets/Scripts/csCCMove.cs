using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCCMove : MonoBehaviour
{
    public float movSpeed = 5.0f;
    public float jumpSpeed = 25.0f;
    public float gravity = 50.0f;
    private bool jumpState;

    CharacterController controller;
    Vector3 moveDirection;
    Vector3 LookV;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        jumpState = false;
    }

    void Update()
    {
       float ver = Input.GetAxis("Vertical");
       float ang = Input.GetAxis("Horizontal");

        if (controller.isGrounded)
        {

            moveDirection = new Vector3(ang,0, ver);
            transform.LookAt(transform.position + moveDirection);
            moveDirection *= movSpeed;

            if (Input.GetKeyDown(KeyCode.Z))
            {
                moveDirection.y = jumpSpeed;
                jumpState = true;
            }
        }


        if (jumpState)
        {
            ver = Input.GetAxis("Vertical");
            ang = Input.GetAxis("Horizontal");

            moveDirection.x = ang * movSpeed;
            moveDirection.z = ver * movSpeed;

            LookV.x = moveDirection.x;
            LookV.y = 0;
            LookV.z = moveDirection.z;
            transform.LookAt(transform.position + LookV);

            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);

            if (controller.isGrounded)
                jumpState = false;
        }
        else
        {
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}