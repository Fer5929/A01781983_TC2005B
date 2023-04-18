/* Eliminates prefabs when touch a destroyer
Fer Colomo */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(col.gameObject);
    }
    //solo se puede llamar uno a la vez 
    /*
    void OnTriggerEnter2D(Collider2D col)
    {
        //Recibe un colider, es decir con qué choqué
        Destroy(col.gameObject);
    }
    */
}
