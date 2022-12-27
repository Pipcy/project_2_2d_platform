/* 7.6
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{
    [SerializeField] private float healthValue; //amount of health restored

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("hitted");
            collision.GetComponent<Health>().AddHealth(healthValue/2);//changed to add half heart if touched
            gameObject.SetActive(false); // deactivate heart so it wont add multiple health
        }
    }
}
