using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public SceneInfo sceneInfo;
    public CharacterController2D controller;

    public float runSpeed = 40f;

    public float horizontalMove = 0f;

    public float jump;

    public Rigidbody2D rb;

    public bool isJumping;

    public CrystalManager cm;


    // Find CrystalManager object/script between scenes. 
    // Check if object is null & if so return error message
    void Awake()
    {
        cm = FindObjectOfType<CrystalManager>();
        if (cm == null)
        {
            Debug.LogError("CrystalManager not found. Make sure it is attached to a GameObject with the DontDestroyOnLoad flag.");
        }
    }


    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        //rb.velocity = new Vector2(runSpeed * horizontalMove, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
        if (SceneManager.GetActiveScene().name == "Level02" && gameObject.name == "Player")
        {
            // Transform.Equals(GetComponent<"Player">, transform);  
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
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Interactible"))
        {
            cm.crystalCount++;
            sceneInfo.crystalTotal++;
        }
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }

    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
