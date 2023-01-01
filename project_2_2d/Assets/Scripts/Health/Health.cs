using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; } //give other script access but can't modify it
    private Animator anim;//7.3
    private bool dead;//7.3

    private void Awake() {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)//7.3
        {
            //player hurt
            anim.SetTrigger("hurt");
            //iframe
        }
        else
        {
            //player dead
            
            if (!dead)
            {
                // foreach (Behaviour component in components)
                //     component.enabled = false;

                Debug.Log("die");
                anim.SetBool("grounded", true);
                anim.SetTrigger("die");
                GetComponent<PlayerMovement>().enabled = false;
                dead = true;
            }
            
        }
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }

    // private void Update() {
    //     if(Input.GetKeyDown(KeyCode.E))
    //         TakeDamage(1);
    // }

    public void Respawn() //2.10
    {
        Debug.Log("respawned");
        dead = false;
        AddHealth(startingHealth);
        
        //anim.SetTrigger("die");
        anim.Play("idle");
        
        GetComponent<PlayerMovement>().enabled = true;
        // foreach (Behaviour component in components)
        //     component.enabled = true;

        
    }
    
}

