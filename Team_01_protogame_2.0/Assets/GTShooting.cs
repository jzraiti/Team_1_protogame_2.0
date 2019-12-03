using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTShooting : MonoBehaviour
{
    public GameObject lime;
    public Transform firePointGT;
    public float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 2)
        {
            ShootGT();
            time = 0;
        }
    }

    void ShootGT()
    {
        Instantiate(lime, firePointGT.position, firePointGT.rotation);
    }
}
