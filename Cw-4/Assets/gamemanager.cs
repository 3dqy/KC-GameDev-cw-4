using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gamemanager : MonoBehaviour
{
    public int score = 0;
    public int Booster = 1;
    public TextMeshProUGUI scoreText;
    public void pressMe()
    {
        score = score + Booster;        
        scoreText.text = ("Score: ") + score;

        print (score);
    }

    public void booster(){
        if (score >= 10)
        {
            Booster++;
            score = score - 10;
            scoreText.text = ("Score: ") + score;
            print("You are using Booster");
        }

        else { print("your score is not enough"); }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
