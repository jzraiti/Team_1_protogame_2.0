using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{

    public float health;


    private void OnCollisionEnter2D(Collision2D collision)
    {


        print("Collision!");

        if (collision.gameObject.tag == "Enemy")
        {
            health -= 10;
            print(health);
        }


    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
