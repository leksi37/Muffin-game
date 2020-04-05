using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    public float Speed;
    //public Rigidbody Rb;
    public float JumpForce;
    public CharacterController Controller;

    private Vector3 MoveDirection;
    public float GravityScale;

    public Animator Animator;
    public Transform Pivot;
    public float RotateSpeed;

    private void Start()
    {
        //Rb = GetComponent<Rigidbody>();
        Controller = GetComponent<CharacterController>();
        
    }

    private void Update()
    {
        //Rb.velocity = new Vector3(Input.GetAxis("Horizontal") * Speed, Rb.velocity.y, Input.GetAxis("Vertical") * Speed);
        //if (Input.GetButtonDown("Jump"))
        //{
        //    Rb.velocity = new Vector3(Rb.velocity.x, JumpForce, Rb.velocity.z);
        //}

        //MoveDirection = new Vector3(Input.GetAxis("Horizontal") * Speed, MoveDirection.y, Input.GetAxis("Vertical") * Speed);
        float yStore = MoveDirection.y;
        MoveDirection = (transform.right * Input.GetAxis("Vertical") * Speed) + (transform.up * Input.GetAxis("Horizontal") * Speed);
        MoveDirection = MoveDirection.normalized * Speed;
        MoveDirection.y = yStore;

        if (Controller.isGrounded)
        {
            MoveDirection.y = 0f;
            if (Input.GetButtonDown("Jump"))
               {
                  MoveDirection.y = JumpForce;
               }
        }
        

        MoveDirection.y = MoveDirection.y + (Physics.gravity.y * GravityScale * Time.deltaTime);
        Controller.Move(MoveDirection * Time.deltaTime);

        //Move the player in different directions based on camera look direction
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            transform.rotation = Quaternion.Euler(-90, 0f,Pivot.rotation.eulerAngles.y);
        }

        Animator.SetBool("isGrounded", Controller.isGrounded);
        Animator.SetFloat("Speed", (Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal"))));
    }
}
