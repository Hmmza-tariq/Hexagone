using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;
    private Boolean Left, Right, Up, Down;
    public AudioSource jumpSound;



    private void Start()
        {
        rb = GetComponent<Rigidbody>();
        Left = false;
        Right = false;
        Up = false;
        Down = false;
        }
    private void Update()
    {
   
        if (Up)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Down)
        {
            transform.position += -Vector3.forward * speed * Time.deltaTime;
        }
        if (Left)
        {
            transform.position += 2*Vector3.left * speed * Time.deltaTime;
        }
        if (Right)
        {
            transform.position += 2*Vector3.right * speed * Time.deltaTime;
        }

    }
    public void Forward()
        {
        Up = true;
        
        }
    public void Backward()
        {
        Down = true;
      
    }
    public void MoveLeft()
        {
        Left = true; ;
        
    }


        public void MoveRight()
        {
        Right = true;
        
        }

    public void Jumping()
    {
        if (IsGrounded())
        {
            jumpSound.Play();
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    public void stopMoving()
    {
        Down = false;
        Left = false;
        Right = false;
        Up = false;
    }

        bool IsGrounded()
        {
            return Physics.CheckSphere(groundCheck.position, .1f, ground);
        }
    
}