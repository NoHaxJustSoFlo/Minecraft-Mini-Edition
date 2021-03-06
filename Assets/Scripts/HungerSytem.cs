using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerSytem : ResourceSystem
{
    float lastUpdateTime;
    float lastHealTime;
    float timeToStarve = 60;
    float lastTimeChanged;

    float velocityX;
    float timeBetweenHeal = 4;
    int numberOfHeals;

    HealthSystem healthSystem;
    Rigidbody2D rb;
    protected override void Awake()
    {
        base.Awake();
        healthSystem = GetComponent<HealthSystem>();
        rb = GetComponent<Rigidbody2D>(); 
    }
    private void Update()
    {
        velocityX = Mathf.Abs(rb.velocity.x);
        if (velocityX >= 3)
        {
            if(Time.time > lastTimeChanged + 1)
            {
                if (velocityX > 5)
                {
                    timeToStarve -= 1.33f;
                }
                else if (velocityX > 4)
                {
                    timeToStarve -= 1f;
                }
                else
                {
                    timeToStarve -= 0.5f;
                }
                lastTimeChanged = Time.time;
            }
        }
        if (Time.time > lastUpdateTime + timeToStarve)
        {
            Decrease(1);
            timeToStarve = 60;
            lastUpdateTime = Time.time;
        }
        if(!healthSystem.IsFull() && !healthSystem.IsEmpty() && resourceList[8].GetFragmentAmount() == 2)
        {
            if (IsFull())
            {
                timeBetweenHeal = 1.5f;
            }
            else
            {
                timeBetweenHeal = 4;
            }
            if (Time.time > lastHealTime + timeBetweenHeal)
            {
                lastHealTime = Time.time;
                numberOfHeals++;
                healthSystem.Increase(1);
                if(numberOfHeals == 4)
                {
                    numberOfHeals = 0;
                    Decrease(1);
                }
            }
        }
    }
}
