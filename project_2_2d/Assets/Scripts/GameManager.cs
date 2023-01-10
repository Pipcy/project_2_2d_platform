//2.15

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public AudioSource winAudio;

    

    void Awake()
    {
        winAudio = GetComponent<AudioSource>();
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true); //enable the winpage UI when win
        winAudio.Play();
        
        //GetComponent<PlayerMovement>().enabled = false;
    }
}
