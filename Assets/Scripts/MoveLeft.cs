using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public int a = 0;
    private float leftBound = -7.0f;
    private float speed = 30.0f;
    private PlayerController playerControllerScript;
    //private SpawnManager sm;

    void Start()
    {
        playerControllerScript = 
            GameObject.Find("Player").GetComponent<PlayerController>();    
        //sm = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("OBSTACLE"))
        {
            Destroy(gameObject);
            //sm.isIdle = true;
        }
    }
}
