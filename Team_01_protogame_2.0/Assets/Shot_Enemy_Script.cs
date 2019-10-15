using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot_Enemy_Script : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }




    public float health = 100;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            health -= 5;

        }
    }
}


