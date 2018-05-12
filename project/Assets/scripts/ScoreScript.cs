using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    private int now = 3;
    private int score = 0;
    public Text scoreLabel;

    void Start()
    {
       
        scoreLabel.text = score.ToString(); 
    }

    void Update()
    {
        InvokeRepeating("AdToScore", 1, 1);
    }

    void AdToScore()
    {
        if (now > 0)
        {
            score = score + 1;
            scoreLabel.text = score.ToString();
        }
    }
}
