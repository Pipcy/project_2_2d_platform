using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float speed;
    private Rigidbody2D body;
    private Animator anim;//**
    private bool grounded;


    void Start()
    {
        //grab references
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();//**
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2( horizontalInput* speed,body.velocity.y);

        //fliping the 2d left and right
        if (horizontalInput < 0f) // input ranges from -1 to 1, positive being right side
            transform.localScale = new Vector3(3,3,3);//picture default move left(do nothing)
        else if (horizontalInput >= 0f) 
            transform.localScale = new Vector3(-3,3,3); //flip image when move right hence change x to -


        //jump
        if(Input.GetKey(KeyCode.Space) && grounded)
            Jump();


        //**set animator parameters
        anim.SetBool("run", horizontalInput != 0); 
        //"horizontalInput != 0" return 1 when input is not zero,
        //and 0 when input is 0, a clever way to shorten the code
        anim.SetBool("grounded", grounded);
    }

    //jump method **
    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        anim.SetTrigger("jump");//**
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }

    
    public bool canAttack()
    {
        return true;
    }
}
