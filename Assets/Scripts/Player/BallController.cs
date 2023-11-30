using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;

    private float speed = 2;

    private Vector3 move = Vector3.right+Vector3.forward; 
    
    
    
    private bool start = false; 
    
    public bool directionX = true;
    
    
    
    public bool isGrounded = true;
    
    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
        
        InputManager.SetGameControls();
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            checkGround();
            
            transform.position += transform.rotation * (speed * Time.deltaTime * move);

            
                if (directionX)
                {
                    transform.position += transform.rotation * (speed * Time.deltaTime * (Vector3.right*5));
                }

                if (!directionX)
                {
                    transform.position += transform.rotation * (speed * Time.deltaTime * (Vector3.forward*5));
                }
        }
    }

    public void startMovement()
    {
        start = true;
    }


    public void changeDirection()
    {
        directionX = !directionX;
    }
    
    private void checkGround()
    {
        //checks to see if the object is touching the ground 
        isGrounded = Physics.Raycast(transform.position, Vector3.down, GetComponent<Collider>().bounds.size.y);
        Debug.DrawRay(transform.position,Vector3.down * GetComponent<Collider>().bounds.size.y, Color.green,0,false);
        
    }


    public bool getGrounded(bool grounded)
    {
        isGrounded = grounded;
        return grounded;
    }
    
    
}
