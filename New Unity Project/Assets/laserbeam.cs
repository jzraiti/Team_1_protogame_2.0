using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserbeam : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public AudioSource audio;
    ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = particleSystem;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            print("Fire1");
            ps.Emit(1);
            audio.Play();
        }
    }

}
