using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float speed =2f; //velocidad para rotar la imagen por segundo
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,speed*360*Time.deltaTime);
    }
}