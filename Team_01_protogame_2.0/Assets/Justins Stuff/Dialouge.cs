using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialouge : MonoBehaviour

{
    // Start is called before the first frame update
    public float timeLeft;
    public int enemiesLeft;
    public Text DialougeText;
    public int drunkness;
    public bool called10 = false;
    public bool called20 = false;
    public bool called30 = false ;
    public bool called50 = false;
    public bool called70 = false;
    public bool called90 = false;
    public bool called110 = false;

    public bool calledh80 = false;
    public bool calledh50 = false;
    public bool calledh30 = false;
    public bool calledh10 = false;
  


    void Start()
    {






        DialougeText = GetComponent<Text>();
        DialougeText.text = "Sup, Im Brad";
        Invoke("RemoveText", 5f);
        timeLeft = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft;
        drunkness = ScoreScript.scoreValue;

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().timeLeft;
        drunkness = ScoreScript.scoreValue;
        

        if (timeLeft > 0)
        {
            //text per drunkness
            if (drunkness == 10 && called10 == false)
            {
                DialougeText.text = "I'm getting Tipsy!";
                Invoke("RemoveText", 5f);
                called10 = true;
            }
            else if(drunkness == 20 && called20 == false)
            {
                DialougeText.text = "I feel like I can fly";
                Invoke("RemoveText", 5f);
                called20 = true;
            }
            else if (drunkness == 30 && called30 == false)
            {
                DialougeText.text = "This is my favorite drinking game!!!! woooo!";
                Invoke("RemoveText", 5f);
                called30 = true;
            }
            else if (drunkness == 50 && called50 == false)
            {
                DialougeText.text = "*hick* aNd thEn i SaId 'YoUr MoM!!' ";
                Invoke("RemoveText", 5f);
                called50 = true;
            }
            else if (drunkness == 70 && called70 == false)
            {
                DialougeText.text = "nvsio agljfdv ubdhf";
                Invoke("RemoveText", 5f);
                called70 = true;
            }
            else if (drunkness == 90 && called90 == false)
            {
                DialougeText.text = "90 BoTtLes f beR oN tHe wAAl ...";
                Invoke("RemoveText", 5f);
                called90 = true;
            }
            else if (drunkness == 110 && called110 == false)
            {
                DialougeText.text = "2 BOTTLES OF BEER! ...";
                Invoke("RemoveText", 5f);
                called110 = true;
            }
            else if (drunkness == 110 && called110 == false)
            {
                DialougeText.text = "thrasher doesnt pay me enough for this s***";
                Invoke("RemoveText", 5f);
                called110 = true;
            }




            if (Timer.dead ==true)
            {
                DialougeText.text = "Ugghhhhhhh... tell chad I love him";
                Invoke("RemoveText", 5f);
            }

            if(HealthScript.health == 80 && calledh80 == false) 
            {
                DialougeText.text = "Watch it! my dads a lawyer!";
                calledh80 = true;
                Invoke("RemoveText", 5f);
            }
            else if(HealthScript.health == 50 && calledh50 == false)
            {
                DialougeText.text = "Can you let someone more sober play!";
                calledh50 = true;
                Invoke("RemoveText", 5f);
            }
            else if (HealthScript.health == 30 && calledh30 == false)
            {
                DialougeText.text = "ughgh... I need a drink...";
                calledh30 = true;
                Invoke("RemoveText", 5f);
            }
            else if (HealthScript.health == 10 && calledh10 == false)
            {
                DialougeText.text = "I hope theres beer in heaven!";
                calledh10 = true;
                Invoke("RemoveText", 5f);
            }


            //text per time left


            //text per enemies left


            //remove text after some time

            //DialougeText.text = timeLeftint.ToString();


        }

    }

    void RemoveText()
    {
        DialougeText.text = "";
    }
}
