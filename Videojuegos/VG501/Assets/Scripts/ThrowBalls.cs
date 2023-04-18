/* Create copies of a ball object to fall on the game scene
Fer Colomo 
2023-04-18*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBalls : MonoBehaviour
{
    [SerializeField]  float delay; //tiempo entre una pelota y otra
    [SerializeField]  GameObject Ball;
    [SerializeField]  float limit;
    // Start is called before the first frame update
    void Start()
    {
        //Call the specified function at regular intervals
        InvokeRepeating("CreateBall",delay , delay); //sirve para llamar una función cada cierto tiempo dado.
    }

    // Update is called once per frame
    void CreateBall()
    {
        Vector3 newPos = new Vector3(Random.Range(-limit, limit),6.5f,0);
        //Crea la copia de la pelota
        Instantiate(Ball,newPos,Quaternion.identity); //Quaternion identity = no rotation.
    }
}
