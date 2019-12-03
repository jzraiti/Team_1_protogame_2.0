using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lime : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 10;
    public Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        HealthScript Player = hitInfo.GetComponent<HealthScript>();
        if (Player != null)
        {
            Player.TakeDamageP(damage);
        }
        Destroy(gameObject);
    }
}
