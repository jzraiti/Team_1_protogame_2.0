using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedSprite : MonoBehaviour
{
    public ParticleSystem particleSystem;
    ParticleSystem ps;
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        ps = particleSystem;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            ps.Play();
            audio.Play();
            gameObject.SetActive(false); //will deactivate not destroy game object DO NOT DESTROY
           
        }
    }
}
