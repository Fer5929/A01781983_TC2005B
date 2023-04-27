using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint_followup : MonoBehaviour
{
    
    // Create an array of waypoints
    [SerializeField] private GameObject[] waypoints;
    private int current_WP=0; // variable que lleva el index de waypoints
    [SerializeField] private float speed=2f; //velocidad con la que se mueve la plataforma
    //1. agregar waypoint1 y waypoint1.2 en el serializefield de movingplatform
    //2.Script
    //3. Agregar un BoxCollider2D para la plataforma para podernos colocar sobre ella
    //4. Cambiar la layer de la plataforma a ground, no tocar el GAMEOBJECT "Moving_Platform_1"
    //5. Crear el script Sticky_Platform para que el jugador se mueva con la plataforma
    // Update is called once per frame
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
        }
        transform.position=Vector2.MoveTowards(transform.position,waypoints[current_WP].transform.position,Time.deltaTime*speed);
        // movimiento de la plataforma, MoveTowards(pos actual, pos a moverse, que tanto quiere moverse aka unidades por segundo)
        //Time.deltaTime toma lo q se toma el tiempo de un frame a otro frame, en este caso nos moveríamos speed por segundo.
    }
}
