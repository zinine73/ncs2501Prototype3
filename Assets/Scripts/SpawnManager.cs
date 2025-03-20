using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public bool isIdle = true;
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    //private float startDelay = 2.0f;
    //private float repeatRate = 2.0f;
    private PlayerController playerControllerScript;
    private float timer = 2.0f;

    void Start()
    {
        playerControllerScript =
            GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        // if (isIdle)
        // {
        //     Invoke("SpawnObstacle", Random.Range(0.0f, 1.0f));
        //     isIdle = false;
        // }
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Invoke("SpawnObstacle", 0);
            timer = Random.Range(0.7f, 2.5f);
        }
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos,
                obstaclePrefab.transform.rotation);
        }
    }
}
