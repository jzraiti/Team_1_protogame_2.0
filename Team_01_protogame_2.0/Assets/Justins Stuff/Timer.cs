using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
    
{
    // Start is called before the first frame update
    //public int enemiesLeft;
    public float timeLeft = 130f;
    public int timeLeftint = 130;

    public Text TimerText;

    public static bool dead = false;

    void Start()
    {
        timeLeft = 130f;
        timeLeftint = 130;

        //enemiesLeft = GameObject.FindGameObjectWithTag("Enemy").GetComponent<enemy>().totalenemies;
        TimerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //enemiesLeft = GameObject.FindGameObjectWithTag("Enemy").GetComponent<enemy>().totalenemies;
        if (timeLeft > 0 && EnemyTracker.finished == false)
        {
            timeLeft -= Time.deltaTime;
            if(timeLeftint>timeLeft)
            {
                timeLeftint -= 1;
            }
            TimerText.text = timeLeftint.ToString();
        }
        if (timeLeft < 0 || dead == true)
        {
            timeLeftint = 0;
            //timeLeft -= Time.deltaTime;
            TimerText.text = "GAME OVER";
            GameStats.TotalScore += (ScoreScript.scoreValue * timeLeftint); 
            Invoke("GameOver", 5f);

            

        }

        
        //Game over program

        //next level program
        if (EnemyTracker.finished ==true && timeLeft > 0)
        {
            TimerText.text = "You WIN!!!";
            GameStats.TotalScore += (ScoreScript.scoreValue + timeLeftint);
            Invoke("NextLevel", 5f);
            
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("Game Over", LoadSceneMode.Single);
    }
    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
    }
}
