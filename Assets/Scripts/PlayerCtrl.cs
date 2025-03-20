using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private float speed;
    private Rigidbody playerRb;
    private float verticlaInput;
    private float horizontalInput;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();    
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MovePlayer(Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MovePlayer(Vector3.back);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MovePlayer(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MovePlayer(Vector3.right);
        }
    }

    private void MovePlayer(Vector3 val)
    {
        playerRb.AddForce(val * 10f, ForceMode.Impulse);
    }
}
