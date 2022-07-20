
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerMove : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
            /*
        }else if (Input.GetAxis("Horizontal")*moveDirection.x < 0)
        {
            moveDirection.x += Input.GetAxis("Horizontal") * 0.02f;
        }
        else if (Input.GetAxis("Vertical")*moveDirection.z <0)
        {
            moveDirection.z += Input.GetAxis("Vertical") * 0.02f;
        }
        else if (Input.GetAxis("Horizontal") * moveDirection.z < 0)
        {
            moveDirection.x += Input.GetAxis("Horizontal") * 0.02f;
        }
        else if (Input.GetAxis("Horizontal") * moveDirection.z > 0)
        {
            moveDirection.x -= Input.GetAxis("Horizontal") * 0.02f;
        }
        else if (Input.GetAxis("Vertical") * moveDirection.x < 0)
        {
            moveDirection.z += Input.GetAxis("Vertical") * 0.02f;
        }
        else if (Input.GetAxis("Vertical") * moveDirection.x > 0)
        {
            moveDirection.z -= Input.GetAxis("Vertical") * 0.02f;
            */
        }

        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);
        controller.Move(moveDirection * Time.deltaTime);
    }
}