using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Button : MonoBehaviour
{
    // Start is called before the first frame update

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
}
