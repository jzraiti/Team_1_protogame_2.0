using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded1 : MonoBehaviour
{
    GameObject Player1;
    

    // Start is called before the first frame update
    void Start()
    {
        Player1 = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player1.GetComponent<PlayerMove1>().isGrounded = true;
            print("grounded");

		}
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player1.GetComponent<PlayerMove1>().isGrounded = false;
            print("NOT GROUNDED");
        }
    }
}
