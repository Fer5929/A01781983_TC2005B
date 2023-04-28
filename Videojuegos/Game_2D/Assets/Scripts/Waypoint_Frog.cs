using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint_Frog : MonoBehaviour
{
   // Create an array of waypoints
    [SerializeField] private GameObject[] waypoints;
    private int current_WP=0; // variable que lleva el index de waypoints
    [SerializeField] private float speed=2f; 
    private SpriteRenderer sprite;
     private void Start()
    {
        sprite=GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if(Vector2.Distance(waypoints[current_WP].transform.position, transform.position)< .1f)//checa la distancia entre la plataforma y un waypoint activo
        {
        // si la distancia entre el currentWP y la plataforma es pequeña significa que hay que cambiar a el siguiente waypoint
        //transform.position es la pos de mi plataforma
        //waypoints[current_WP].transform.position es la pos de mi currentWP
        current_WP ++;
            if(current_WP >= waypoints.Length)
             { //asi volvemos al WP inicial del arreglo de waypoints
                current_WP = 0; 
            }
            if (current_WP == 0)
            {
                sprite.flipX=true;
            }
            else
            {
                {
                    sprite.flipX=false;
                }
            }
        }
        transform.position=Vector2.MoveTowards(transform.position,waypoints[current_WP].transform.position,Time.deltaTime*speed);
        // movimiento de la plataforma, MoveTowards(pos actual, pos a moverse, que tanto quiere moverse aka unidades por segundo)
        //Time.deltaTime toma lo q se toma el tiempo de un frame a otro frame, en este caso nos moveríamos speed por segundo.
    }
}
