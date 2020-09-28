using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] 
    private float secondsBetweenSpawn;
    [SerializeField]
    private float maxSpawnrate =0f;
    private float elapsedTime = 0f;
    public MovingPlatform MovingPlatform;
    public GameObject platformPrefab;
    private List<GameObject> platforms;
    private float platformSpeed;
    private float platformAcceleration;


    private void Start()
    {
        platforms = new List<GameObject>();
        spawnPlatform();
    }

    void Update()
    {
        MovingPlatform.increaseSpeed();

        elapsedTime += Time.deltaTime;
        
        if (elapsedTime > secondsBetweenSpawn)
        {
            elapsedTime = 0;
            
            spawnPlatform();
        }
        
        decreaseSpawnTime();
        
    }

   public void spawnPlatform()
    {
        float randomPosition = Random.Range(1.0f, 10.0f);
        Vector3 spawnpoint = new Vector3(randomPosition, -28f, 38.8457f);
        
        GameObject platform  = (GameObject)Instantiate(platformPrefab,spawnpoint, Quaternion.identity);
        platforms.Add(platform);
        Destroy(platform, 6f);
    }
	
    void decreaseSpawnTime()
    {
        if (secondsBetweenSpawn > maxSpawnrate)
        {
            secondsBetweenSpawn -= 0.000099f * Time.timeScale;
        }
    }

    public void destroyAllPlatform()
    {
        foreach (GameObject platform in this.platforms)
        {
            Destroy(platform);
        }
    }



    public float SecondsBetweenSpawn
    {
        get => this.secondsBetweenSpawn;
        set => this.secondsBetweenSpawn = value;
    }
}
