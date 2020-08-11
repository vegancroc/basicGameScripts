using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingGround : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform myObj1;
    public Transform myObj2;
    public float movingSpeed;
    bool movingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
        if (transform.position.x < myObj1.position.x)
        {
            movingRight = true;
        }
        else if (transform.position.x > myObj2.position.x)
        {
            movingRight = false;
        }
        if (movingRight)
        {
            transform.position = new Vector2(transform.position.x + movingSpeed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - movingSpeed * Time.deltaTime, transform.position.y);

        }

    }


}
