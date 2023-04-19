using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnitiyEngine.UI;
using TMPro;



public class Score : MonoBehaviour
{
int points;
[SerializeField] TMP_Text scoreText;
[SerializedField] ParticleSystem particles;
    // Start is called before the first frame update
    void Start()
    {
        points=0;
    }

    // Update is called once per frame
   
     void OnTriggerEnter2D(Collider2D col)
    {
        points +=1;
        scoreText.text="Score: " + points; 
        //print ("Points: " +points);
        particles.Emit(15);

        //Instantiate(particles,transform.position, Quaternion.identity);
        Destroy(col.gameObject);
    }
}
