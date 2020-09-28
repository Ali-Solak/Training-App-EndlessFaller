using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private int Score;
    public Text scoreUiText;
    public GameObject mainCharacter;
    public PlatformSpawner platformSpawner;
    public GameObject mainCharacterPrefab;
    public GameObject gameOverScreen;
    public MovingPlatform platformPrefab;
    private int highScore;
    private HighScoreXML highScoreXml;

    private void Start()
    { 
        highScoreXml = new HighScoreXML();
        highScore = highScoreXml.load();
    }

    void Update()
    {
        setHighScore();
        scoreUiText.text = "Score: " + Score;
        highScore = highScoreXml.load();
        gameOver();
    }

    public void IncrementScore()
    {
        Score++;
    }

    void resetScore()
    {
        this.Score = 0;
    }

    void setHighScore()
    {
        if (Score > highScore)
        {
            highScoreXml.saveHighscore(Score);
            
        }
    }

    private void gameOver()
    {
        if (mainCharacter!=null && mainCharacter.transform.position.y > 10f || mainCharacter!=null && mainCharacter.transform.position.y < -9f)
        {
            platformSpawner.enabled = false;
            gameOverScreen.SetActive(true);
            platformSpawner.destroyAllPlatform();
            
            platformPrefab.Speed = 0.05f;
            platformPrefab.Acceleration = 0f;
            platformSpawner.SecondsBetweenSpawn = 1.1f;
            
            Destroy(mainCharacter);
        }
    }
    

     public void restart()
     {
         Vector3 spawnpoint = new Vector3(3.08f,3.33f,-1.85f);
         mainCharacter = (GameObject) Instantiate(mainCharacterPrefab, spawnpoint, Quaternion.identity);
         
         resetScore();
         gameOverScreen.SetActive(false);
         platformSpawner.enabled = true;
     }
     
     public int score
     {
         get => this.Score;
         set => this.Score = value;
     }

     public int HighScore
     {
         get => this.highScore;
         set => this.highScore = value;
     }
     
}

