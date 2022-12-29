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

    //mouse aiming
    public Camera cam;
    Vector2 mousePos;
    //

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

        //mouse aiming code
        // Vector2 lookDir = mousePos - body.position;
        // float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 0f;

        // if (angle > -90 && angle < 90) 
        // {
            
        // }else{ 
        //     bullets[FindBullet()].transform.rotation = firePoint.rotation - 180f;//*** added this line myself to allow
        //                                                               // bullets to be shoot 360 degree // learned from point to shoot Í
        // }
        //

        //pool fireballs
        bullets[FindBullet()].transform.position = firePoint.position;//set the pos of the bullet from
        bullets[FindBullet()].transform.rotation = firePoint.rotation;//*** added this line myself to allow
                                                                      // bullets to be shoot 360 degree // learned from point to shoot Í
        bullets[FindBullet()].GetComponent<Projectile>().SetDirection(-Mathf.Sign(transform.localScale.x));//set the direction the bullets


    }
    //bullet pooling
    private int FindBullet()
    {
        for (int i = 0; i < bullets.Length; i++)
        {
            if(!bullets[i].activeInHierarchy)//if the ith bullet is not active, then yes you can use 
                return i;
        }
        return 0;
    }
    
}
