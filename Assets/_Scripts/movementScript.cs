using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{   
    [SerializeField]
    private float Speed;
    [SerializeField]
    private float JumpForce;
    [SerializeField]
    private float RotateSpeed;
    [SerializeField]
    private float GravityScale;

    [SerializeField]
    private Transform Pivot;
    private CharacterController Controller;
    private Vector3 MoveDirection;
    private Animator Animator;
    
    private void Start()
    {
        Controller = GetComponent<CharacterController>();
        Animator = GetComponent<Animator>();    
    }

    private void Update()
    {
        float yStore = MoveDirection.y;

        //Different directions that the ones in the youtube tutorial, because of inverted axis of the Cupcacke
        //Right => Forward and Up => Right.
        //It moves the player according to which direction the camera is facing
        MoveDirection = (transform.right * Input.GetAxis("Vertical") * Speed) + (transform.up * Input.GetAxis("Horizontal") * Speed);

        //Limits the diagonal speed 
        MoveDirection = MoveDirection.normalized * Speed;

        //Applying the normalized speed to jump as well
        MoveDirection.y = yStore;

        //Player can jump only when is on the ground
        if (Controller.isGrounded)
        {
            MoveDirection.y = 0f;
            if (Input.GetButtonDown("Jump"))
               {
                  MoveDirection.y = JumpForce;
               }
        }
        
        //Applying smoother gravity for the player
        MoveDirection.y = MoveDirection.y + (Physics.gravity.y * GravityScale * Time.deltaTime);
        
        //Moving player with one per frame
        Controller.Move(MoveDirection * Time.deltaTime);

        //Move the player in different directions based on camera look direction
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            transform.rotation = Quaternion.Euler(-90, 0f,Pivot.rotation.eulerAngles.y);
        }

        //Helping with changing between the three states of the player : walking, jumping and idle
        Animator.SetBool("isGrounded", Controller.isGrounded);
        Animator.SetFloat("Speed", (Mathf.Abs(Input.GetAxis("Vertical")) + Mathf.Abs(Input.GetAxis("Horizontal"))));
    }
}
