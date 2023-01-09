/* 7.6
11.4 audio
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    [SerializeField] private float healthValue; //amount of health restored
    public AudioSource collectAudio;

    public bool collected = false;

    private void Awake() {
        collectAudio = GetComponent<AudioSource>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            if (!collected)//*
            {
                collectAudio.Play();
                collision.GetComponent<Health>().AddHealth(healthValue);//changed to add half heart if touched
                gameObject.GetComponent<SpriteRenderer>().enabled = false;//*
                collected = true;//*
                //*fixes 11.3
                //gameObject.SetActive(false); // deactivate heart so it wont add multiple health
            }
           
        }

    }
}
