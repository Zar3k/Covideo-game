﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;


    // Update is called once per frame
    private void Update()
    {
        if(timeBtwSpawn <= 0)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;

            if(startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }

        if (ScoreScript.scoreValue >= 20)
        {
            timeBtwSpawn = 10000000000000;
        }
    }
}
