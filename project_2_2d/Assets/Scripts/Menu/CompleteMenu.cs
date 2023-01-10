//2.13.1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//****

public class CompleteMenu : MonoBehaviour
{
    public void BacktoMain() // play button
    {
        SceneManager.LoadScene("Menu"); // load the next scene in the index
    }

    public void QuitGame() //quit button
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
