using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
   public void Play()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game.");
    }
    //public void HowToPlay(){ SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);}public void options{ SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);} 
}
