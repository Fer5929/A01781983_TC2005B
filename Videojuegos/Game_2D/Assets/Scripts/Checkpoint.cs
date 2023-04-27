using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private AudioSource checkpoint_SE;
    // Start is called before the first frame update
    private bool levelCompeleted= false;
    void Start()
    {
        checkpoint_SE=GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="Player"&& !levelCompeleted)
        {
            checkpoint_SE.Play();
            levelCompeleted=true;
            Invoke("CompleteLevel",2f);
            //llama al nivel después de dos segundos
        }
    }
    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    
}
