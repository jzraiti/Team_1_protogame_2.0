using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTracker : MonoBehaviour
{
    public int startnumenemies;
    public static int deadenemies;
    public static bool finished;
    // Start is called before the first frame update
    void Start()
    {
        deadenemies = 0;
        finished = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (deadenemies == startnumenemies)
        { finished = true;  }
    }
}
