using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    
    public float speed = 20f;
    public float turnSmoothTime = 0.1f;
    public float gravity = -22f;
    public float groundDistance = 0.4f;
    public float jumpHeight = 2f;
    float turnSmoothVelocity;

    public Transform groundCheck;

    public LayerMask groundMask;
    

    Vector3 velocity;

    bool isGrounded;
    
    void start(){
    controller.minMoveDistance = 0f;
    }
    
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
       Vector3 direction = new Vector3(horizontal, 0, vertical);
       float magnitude = Mathf.Clamp01(direction.magnitude) * speed;
       direction.Normalize();

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
            controller.Move(direction * speed * Time.deltaTime);
        }
      
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


    }
}
