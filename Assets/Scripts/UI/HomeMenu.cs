using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HomeMenu : MonoBehaviour
{
    public Text highScore;
    private HighScoreXML highScoreXml;
	
    private void Start()
    {
        highScoreXml = new HighScoreXML();
        highScore.text = "Highscore: " + highScoreXml.load().ToString();
    }
}