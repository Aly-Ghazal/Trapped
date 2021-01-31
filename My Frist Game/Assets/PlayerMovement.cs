using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public static bool freezed = false;
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    public Animator animator;
    //bool jump = false;
    //bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        if(!freezed)
        {
            horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove) );
        }
    }

    void FixedUpdate()
    {
        // Move our character
        if(!freezed)
            controller.Move(horizontalMove * Time.fixedDeltaTime, true, false);
    }
}