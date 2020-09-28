using System;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float acceleration;
    [SerializeField] private float maxSpeed =0f;
    
    
    void Update()
    {
        transform.position += Vector3.up * speed * Time.timeScale;
    }

    public float Speed
    {
        get => this.speed;
        set => this.speed = value;
    }

    public float Acceleration
    {
        get => this.acceleration;
        set => this.acceleration = value;
    }

    public void increaseSpeed()
    {
        if (speed < maxSpeed)
        {
            acceleration += 0.000000000321f * Time.timeScale;
            speed += acceleration * Time.timeScale;
        }
    }
}