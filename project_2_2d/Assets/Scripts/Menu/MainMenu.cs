//2.13.1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//****

public class MainMenu : MonoBehaviour
{
    public void loadLevels() // play button
    {
        SceneManager.LoadScene("Levels"); 
    }

    public void PlayGame1() // play button
    {
        SceneManager.LoadScene("LevelA"); 
    }

    public void PlayGame2() // play button
    {
        SceneManager.LoadScene("LevelB"); // load the next scene in the index
    }

    public void QuitGame() //quit button
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 ); // load the next scene in the index