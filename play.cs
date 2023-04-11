using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class play : MonoBehaviour
{
   public void next1()
   {
    SceneManager.LoadScene(1);
   }
   public void next2()
    {
        SceneManager.LoadScene(2);
    }
   public void next3()
   {
      SceneManager.LoadScene(3);
   }
   public void next4()
   {
      SceneManager.LoadScene(4);
   }
}
