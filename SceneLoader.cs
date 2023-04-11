using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    
    public void LoadNextScene(){
       SceneManager.LoadScene(1);
    }

    public void LoadHelpScene(){
        SceneManager.LoadScene(2);
    }

    public void LoadCreditsScene(){
        SceneManager.LoadScene(3);
    }
    
   
}
