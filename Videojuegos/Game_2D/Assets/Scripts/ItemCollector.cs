using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // bajar para manejar texto

public class ItemCollector : MonoBehaviour
{
    //1 create new 2D - sprite - square- renombrar como "item"
    //2 arrastrar la primera imagen de melon a sprite en sprite renderer de "item"
    //3 agregar un boxcollider2D y poner IsTrigger 
    //4 crear una nueva animación y arrastrar a "item"
    //5 cambiar a 16 px y arrastrar la imagen
    //6 añadir la animación a "item"
    //7 en "item" agregar un tag, en este caso "sandia"
    //8 hacer un nuevo script en player (este script)
    //9 Crear un prefab de sandía (arrastrar "item" a proyect donde están los assets a la nueva carpeta de Prefab)
    //10 arrastrar más sandías a la escena
    //11 crear un emptyobj para ordenar las nuevas sandías, arrastrar "item" y las nuevas sandías ahí
    //12 cambiar sus posiciones para que se vea bonito
    //13 Descargar font de google fonts, descomprimir 
    //14 crear carpeta para fonts y arrastrar el archivo .tttf
    //15 seleccionar la font, en inspect los tres puntitos y poner la opcion de TMF file
    //16 oprimier generate atlas y save
    //17 ir al texto "Sandia_TXT" y arrastrar el archivo que se acaba de crear en font style
    //18 en el texto, "Sandia_TXT" en text transform elegir la posision adecuada
    //19 bajar el using de TMPro para el texto 
    //20 arrastrar el "Sandia_TXT" al serializeField de player de este script
    //colisión
    private int sandias = 0;//contador
    [SerializeField] private TMP_Text sandiasTXT;
    [SerializeField] private AudioSource collector_SE;
    void OnTriggerEnter2D(Collider2D collision) //se usa porque pusimos que la sandia era un trigger en su boxcollider
    {
        
        if(collision.gameObject.CompareTag("Sandia"))//revisa si hubo una colisión con la sandia
        {
            Destroy(collision.gameObject);//elimina el objeto en cuestion
            sandias ++;
            sandiasTXT.text= "Fruits: "+sandias;
            collector_SE.Play();
        }
    }
}
