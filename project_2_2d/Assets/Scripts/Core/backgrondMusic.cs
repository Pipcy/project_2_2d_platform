using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgrondMusic : MonoBehaviour
{
    public AudioSource music;
    public EndTrigger end;

    void Awake()
    {
        music = GetComponent<AudioSource>();
        //end = GetComponent<EndTrigger>();
    }

    void Update()
    {
        
        if (end.win == true)
            music.Pause();
    }
    
}
