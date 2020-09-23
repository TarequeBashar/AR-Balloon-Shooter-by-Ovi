﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform[] spawnPoints;
    public GameObject[] ballons;
    void Start()
    {

        StartCoroutine(StartSpawning());



    }

    // Update is called once per frame
   IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);

        for(int i = 0; i<3; i++)
        {

            Instantiate(ballons[i],spawnPoints[i].position,Quaternion.identity);
        }

        StartCoroutine(StartSpawning());


    }
}
