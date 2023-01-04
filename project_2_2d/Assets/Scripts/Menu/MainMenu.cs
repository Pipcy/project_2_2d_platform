//2.13.1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//****

public class MainMenu : MonoBehaviour
{
    public void PlayGame() // play button
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 ); // load the next scene in the index
    }

    public void QuitGame() //quit button
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
