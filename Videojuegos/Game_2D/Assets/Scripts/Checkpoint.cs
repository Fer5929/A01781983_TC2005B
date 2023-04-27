using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private AudioSource checkpoint_SE;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint_SE=GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="Player")
        {
            checkpoint_SE.Play();
            CompleteLevel();
        }
    }
    private void CompleteLevel()
    {

    }

    
}
