﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNuke : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] randomNuke;

    public int startSpawnTime = 10;
    public int spawnTime = 5;


    // Use this for initialization
    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", startSpawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spawn()
    {
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPoints = Random.Range(0, 5);
        int randomNuke = Random.Range(0, 3);

        // Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
        Instantiate(this.randomNuke[randomNuke], this.spawnPoints[spawnPoints].position, this.spawnPoints[spawnPoints].rotation);
    }

}
