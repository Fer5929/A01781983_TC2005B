using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    private Rigidbody2D rb; //creation of a rigibody type variable 
    //only this script can access this rb variable. 
    private Animator anim;
    // Start is called before the first frame update
    private float dirX =0;
    [SerializeField]private float moveSpeed =7f;
    [SerializeField]private float jumpForce=14f;
    private SpriteRenderer sprite; //object of type SpriteRenderer
    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
        sprite=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {   dirX=Input.GetAxisRaw("Horizontal"); // if dirX = 0 then no movement.
        rb.velocity=new Vector2(dirX * moveSpeed,rb.velocity.y); //actual pos * movement. 
       if(Input.GetButtonDown("Jump"))
       {
           rb.velocity = new Vector2(rb.velocity.x,jumpForce); 
       }
       
        UpdateAnimation();
    }
    private void UpdateAnimation()
{
    if(dirX>0f)
       {
            anim.SetBool("running",true);
            sprite.flipX=false;
       }
       else if(dirX < 0f) //just in case there is another animation
       {
            anim.SetBool("running",true);
            sprite.flipX=true;
       }
       else
       {
            anim.SetBool("running",false);
       }
}
}

