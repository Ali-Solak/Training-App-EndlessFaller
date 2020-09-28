using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    [SerializeField] private float speed = 0f;
    public GameObject levelManager;

    void Start()
    {
        levelManager = GameObject.Find("LevelManager");
    }
	
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed;
        }
    }
    
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "ScoreCollider")
        {
            levelManager.GetComponent<LevelManager>().IncrementScore();
        }
    }

}
