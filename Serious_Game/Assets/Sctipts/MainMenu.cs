using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

     public void highscore()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame() {
        
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
