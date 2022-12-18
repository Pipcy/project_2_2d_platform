using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform firePoint;// position where the bullet will be fireed
    [SerializeField] private GameObject[] bullets;

    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    void Start()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerMovement.canAttack())
            Attack();

        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;//

        //pool fireballs
        bullets[0].transform.position = firePoint.position;//set the pos of the bullet from
        bullets[0].GetComponent<Projectile>().SetDirection(-Mathf.Sign(transform.localScale.x));//set the direction the bullets


    }
    
}
