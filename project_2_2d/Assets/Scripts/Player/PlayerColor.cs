using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    //private color PlayerColor;
    SpriteRenderer sprite;
    [SerializeField] public float groundDamage;
    public Color color = new Color (0, 1, 0, 1); // starting color green
    public float colorCode;

    void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
        
        //color starts out green
        sprite.color = color;
        colorCode = 6; //layer6
        
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))//Red
        {            
            // Change the 'color' property of the 'Sprite Renderer'
            sprite.color = new Color (1, 0, 0, 1); 
            colorCode = 11; //layer11
        }
        else if(Input.GetKeyDown(KeyCode.E))//Green
        {            
            sprite.color = new Color (0, 1, 0, 1); 
            colorCode = 6; //layer6
        }
        else if(Input.GetKeyDown(KeyCode.Q))//Blue
        {            
            sprite.color = new Color (0, 0, 1, 1); 
            colorCode = 10; //layer10
        }

        else if(Input.GetKeyDown(KeyCode.F))//purple
        {            
            sprite.color = new Color (145/255, 11/255, 145/255); 
            colorCode = 9; //layer9
        }

        
    } 

    // private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     ;//Debug.Log(collision.gameObject.tag);
    //     // if (collision.gameObject.tag == "Player")
    //     //     Debug.Log("Here");
    //     //collision.GetComponent<Health>().TakeDamage(damage);
    // } 
    
}



