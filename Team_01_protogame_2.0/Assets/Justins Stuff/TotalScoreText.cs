using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScoreText : MonoBehaviour
{
    public int scoreValue;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        scoreValue = GameStats.TotalScore;
        score.text = scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
