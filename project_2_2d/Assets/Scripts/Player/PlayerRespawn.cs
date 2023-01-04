//2.10
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    //[SerializeField] private AudioClip checkpointSound; //audio when touch checkpoint
    private Transform currentCheckpoint; //store pos of latest checkpoint
    private Health playerHealth; //restore health when respawn
    

    private void Awake() {
        playerHealth = GetComponent<Health>();
    }

    public void Respawn()
    {
        //Debug.Log("Respawned first");
        transform.position = currentCheckpoint.position; //move player to checkpoint position
        playerHealth.Respawn();//restore health and reset animation

        
        
    }

    //activate checkpoints
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Checkpoint")
        {
            Debug.Log("checkpoint detected");

            currentCheckpoint = collision.transform;
            //SoundManager.instance.PlaySound(checkpointSound);
            collision.GetComponent<Collider2D>().enabled = false;
            //collision.GetComponent<Animation>().SetTrigger("appear");//trigger checkpoint animation
            
        }

    }
    // private void Update() {
    //     Debug.Log("respawnComplete: " + respawnComplete);
    // }
}