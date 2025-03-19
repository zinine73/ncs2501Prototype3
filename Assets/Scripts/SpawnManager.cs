using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public bool isIdle = true;
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    //private float startDelay = 2.0f;
    //private float repeatRate = 2.0f;
    private PlayerController playerControllerScript;

    void Start()
    {
        playerControllerScript =
            GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (isIdle)
        {
            Invoke("SpawnObstacle", Random.Range(0.0f, 1.0f));
            isIdle = false;
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
