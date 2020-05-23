using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   public void Play()
    { 
        SceneManager.LoadScene("Gameplay");
        SceneManager.GetActiveScene().GetRootGameObjects();
    }

    public void PlayAgain()
    {
        Debug.Log("Play again");
        SceneManager.UnloadScene("Gameplay");
        SceneManager.LoadScene("Gameplay");
       
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void Pause()
    {
        SceneManager.LoadScene("Pause");
    }
    //public void Continiue()
    //{
    //    SceneManager.LoadScene("");
    //}
    public void Exit()
    { 
        UnityEngine.Debug.LogError("Exit Game");
        Application.Quit();
    }
}
