using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableScript : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            
            gameObject.SetActive(false); //will deactivate not destroy game object DO NOT DESTROY
            ScoreScript.scoreValue += 10;
           

            
        }
    }
}
