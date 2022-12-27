using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//7.5
public class enemy_sideways : MonoBehaviour
{
  
    [SerializeField] private float damage;
    //deleted a bunch, didnt use the tutorial's way, used pill game waypoint follower logic instead

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
    }
}
