using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOver : MonoBehaviour
{
    public Text ScoreThisRound;
    public Text highScoreUiText;
    public LevelManager LevelManager; 

    void Update()
    {
        ScoreThisRound.text = "Round Score: " + LevelManager.score;
        highScoreUiText.text = "Highscore: " + LevelManager.HighScore;
    }
}