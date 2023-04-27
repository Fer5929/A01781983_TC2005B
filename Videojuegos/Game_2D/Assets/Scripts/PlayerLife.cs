using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    [SerializeField] private AudioSource death_SE;
    // Start is called before the first frame update
    void Start()
    {   anim=GetComponent <Animator>();
        rb=GetComponent<Rigidbody2D>();
        //como las espinas no son un trigger usarmos oncollisionenter2d
       
        
    }
     private void OnCollisionEnter2D(Collision2D collision) {
            //Debemos detectar las spikes entonces le agregamos una tag como en sandia
            if(collision.gameObject.CompareTag("Trap_Spikes"))
            {
                Die();
                death_SE.Play();
            }
        }
    private void Die()
        {
            
            anim.SetTrigger("death");
            rb.bodyType=RigidbodyType2D.Static; //evita que me pueda mover si me topo con un obstáculo
            
        }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//Reaload de current level
    }

   //para lograr que después de Die se espere un tiempo antes de reiniciar el nivel
   //1. Ir a animations a "player_Death", luego grabar un cuadro más sin el spriteRenderer para arreglar la vista de la animación
   //2. Después en Animation, seleccionar un tiempo después, poner el cursor y luego elegir add animation event ( es como un +con un rectángulo)
   //3. Ahí en function seleccionar RestartLevel()
}
