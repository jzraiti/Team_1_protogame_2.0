using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject pingPong;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            
        }

        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetBool("IsThrowing", false);
        }
    }

       void Shoot()
        {
        animator.SetBool("IsThrowing", true);
        Instantiate(pingPong, firePoint.position, firePoint.rotation);
        //animator.SetBool("IsThrowing", false);
     
        }
}
