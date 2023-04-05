using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text score, highScore;
    int scoreCounter = 0;
    int highScoreCounter;
    

    void Start()
    {
        
    }

    void Update()
    {
        score++;

        if(score > highscore)
        {
            highscore = score;
        }
    }
}
