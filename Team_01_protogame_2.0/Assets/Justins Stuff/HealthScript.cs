using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{

    public static int health=100;


    private void OnCollisionEnter2D(Collision2D collision)
    {


        print("Collision!");

        if (collision.gameObject.tag == "Enemy")
        {
            health -= 10;
            print(health);
            ScoreScript.scoreValue -= 5;
        }


    }

	public void TakeDamageP(int damage)
	{
		health -= damage;
	}



	// Start is called before the first frame update
	void Start()
    {
		health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Timer.dead = true;
        }
    }


}
