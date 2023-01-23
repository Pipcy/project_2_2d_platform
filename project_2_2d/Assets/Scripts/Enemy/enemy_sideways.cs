using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//7.5
public class enemy_sideways : MonoBehaviour
{
  
    [SerializeField] private float damage;
    //deleted a bunch, didnt use the tutorial's way, used pill game waypoint follower logic instead

    private bool killed = false;

    // //detect respawn
    // public PlayerRespawn respawn;

    // void Awake()
    // {
    //     respawn = GetComponent<PlayerRespawn>();

        
    // }

    // void Update()
    // {
    //     if (respawn.respawnCheck == true)
    //     {   
    //         EnemyRespawn();
    //     }
    // }


    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!killed)
                collision.GetComponent<Health>().TakeDamage(damage);
        }
        else if (collision.tag == "Bullet")
        {
            if (!killed)//*
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;//*
                killed = true;//*
                //*fixes 11.3
                //gameObject.SetActive(false); // deactivate heart so it wont add multiple health
            }
        }
    }

    // private void EnemyRespawn()
    // {
    //     if (killed)
    //     {
    //         gameObject.GetComponent<SpriteRenderer>().enabled = true;//*
    //         killed = false;
    //         respawn.respawnCheck = false;
    //     }
    // }
}
