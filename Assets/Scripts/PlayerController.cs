using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private Rigidbody2D characterRigidbody;
    private float horizontalInput; 
    public static Animator characterAnimator; 

    [SerializeField]private float characterSpeed = 4.5f;
    [SerializeField]private float jumpForce = 10f;

      


    void Awake()
    {
        characterRigidbody = GetComponent<Rigidbody2D>();
           characterAnimator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
          

    }
    void Movement()
    {
        if( horizontalInput == 0)
        {
            horizontalInput = 0; 
        }
        else
        {
            horizontalInput = Input.GetAxis("Horizontal");
        }
        if(horizontalInput < 0)
        {
           
            characterAnimator.SetBool("IsRunning", true);

        }
        else if(horizontalInput > 0)
        {
           
            characterAnimator.SetBool("IsRunning", true);

        }
        else
        {
            characterAnimator.SetBool("IsRunning", false);
        }
    }

    void Update()
    {
        Movement();

        if(Input.GetButtonDown("Jump")GroundSensor.isGrounded)
        {
            characterRigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            characterAnimator.SetBool("IsRunning", false);



        }
     

       
    }
   
}
