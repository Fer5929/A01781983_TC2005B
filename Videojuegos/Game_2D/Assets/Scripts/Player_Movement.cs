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

    // variable to manage animation
    private enum MovementState {idle, running, jumping, falling};

    //para IsGrounded se busca una referencia al boxcollider
    private BoxCollider2D coll;
    [SerializeField] private LayerMask jumpableGround;
    
    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
        sprite=GetComponent<SpriteRenderer>();
        coll=GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void Update()
    {   dirX=Input.GetAxisRaw("Horizontal"); // if dirX = 0 then no movement.
        rb.velocity=new Vector2(dirX * moveSpeed,rb.velocity.y); //actual pos * movement. 
       if(Input.GetButtonDown("Jump")&&IsGrounded())
       {
           rb.velocity = new Vector2(rb.velocity.x,jumpForce); 
       }
       
        UpdateAnimation();
    }
    private void UpdateAnimation()
{
    MovementState state;
    if(dirX>0f)
       {
            //anim.SetBool("running",true);
            state=MovementState.running;
            sprite.flipX=false;
       }
       else if(dirX < 0f) //just in case there is another animation
       {
            //anim.SetBool("running",true);
            state=MovementState.running;
            sprite.flipX=true;
       }
       else
       {
            state=MovementState.idle;
            //anim.SetBool("running",false);
       }
       if(rb.velocity.y >.1f) //we are jumping
       {
            state=MovementState.jumping;
       }
       else if (rb.velocity.y < -.1f)//fallling
       {
        state=MovementState.falling;
       }
       anim.SetInteger("state",(int)state);
}
//ground check, permite que el jugador solo salte una vez revisando si ya tocó el piso
private bool IsGrounded ()
{
    return Physics2D.BoxCast(coll.bounds.center,coll.bounds.size,0f,Vector2.down,.1f,jumpableGround);
    //Se crea una caja alrededor del jugador q tiene el mismo tamaño que el boxcollider de player
    //0f para no rotar 
    //Vecto2.down mueve ligeramente esa caja abajo para checar si algo se "overlapea" con nuestro player aka tocamos el piso
    //.1f es lo que se mueve 
    // Se creó una Layer "Ground" para el Terrain, se crea un objeto de LayerMask llamado "jumpableGround" que me sirve para ver si con lo que choqué era piso
}
}

