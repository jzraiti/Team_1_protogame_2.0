using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;
    public int damage = 10;
    //public int totalenemies;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            EnemyTracker.deadenemies += 1; 
            ScoreScript.scoreValue += 10;
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        //Destroy(gameObject);
        gameObject.SetActive(false);

    }
    // Start is called before the first frame update
    void Start()
    {
        //totalenemies = GameObject.FindGameObjectWithTag("Etracker").GetComponent<EnemyTracker>().startnumenemies;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
