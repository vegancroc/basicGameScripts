using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    bool cameraLock;
    public Transform player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cameraLock = !cameraLock;
        }
        else if (!cameraLock)
        {
            transform.position = new Vector3(player.position.x + 2, 0, -10);
        }
    }

     
}
