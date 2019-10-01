using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{

	private Rigidbody2D rb2d;
    private int score;

	public float speed; 
    public string score_reg; 
	// Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }
    void FixedUpdate()
    {
    	float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
    	Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

    	rb2d.AddForce(movement * speed); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false); //will deactivate not destroy game object
            score += 1;
            print(score);
            setScore();
        }
    }

    private void setScore()
    {
        score_reg = score.ToString();

    }
}
