using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    // These are variables for the attempt at making a jump function 
    //public float jumpSpeed = 1f; 
    //public float verticalMove = 0f; 
    public float runSpeed = 40f;
    
    public float horizontalMove = 0f;
    
    public float jump; 

    public Rigidbody2D rb; 

    public bool isJumping; 

    public CrystalManager cm;


    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

       //rb.velocity = new Vector2(runSpeed * horizontalMove, rb.velocity.y);
        
        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

       
        //  This was an attempt to use our knowledge to create a jump button - we instead 
        // created a teleport that moves the player horizontally at a set distance / speed
        //verticalMove = Input.GetAxisRaw("Vertical") * jumpSpeed; 

    }
    void FixedUpdate()
    {
        // Move Our Character 
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
        //jump = false; 


        /* 
        This was an attempt to use our knowledge to create a jump button - we instead 
        created a teleport that moves the player horizontally at a set distance / speed. 

        controller.Move(verticalMove * jumpSpeed, false, true); 
        */
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Interactible"))
        {
            cm.crystalCount++; 
        }
    }
}
