using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticky_Platform : MonoBehaviour
{
    //Se hace para revisar si hay una colisión entre la plataforma y player
    /*
    void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    // ahora haremos otro método para que player deje de ser un hijo de la movingplatform al momento de salir de ella

     void OnCollisionExit2D(Collision2D collision)//cuando el jugador salga, de ahí el Exit
    {
        
    }
    */ //se usó antes cuando solo había un boxcollider (ignorar)

    //1. en movingplatform crear un nuevo boxcollider2D, ahí hacer que sea un trigger
    //ponerlo "sobre el otro boxcollider2D" y recortar las esquinas
    //2.script
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="Player")//se usa este tipo de comparación en vez de tags porque solo tenemos un solo player
        {
            collision.gameObject.transform.SetParent(transform);
            //transform siendo el pos de la plataform
            //lo que hacemos es que player se vuelve un hijo de nuestra movingplatform para lograr que se mueva junto con la plataforma
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name=="Player")//se usa este tipo de comparación en vez de tags porque solo tenemos un solo player
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
    //3. cambiar el orden de la layer en additional layer, =1
}
