using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballTeleport : MonoBehaviour
{
    Rigidbody2D rb;
    Transform tplocation;
    public LayerMask myLayer;
    public float radius = 0.5F;
    public Transform myobj;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tplocation = GameObject.Find("tp").transform;
    }

    void Update() { }


    void FixedUpdate()
    {
        bool isFallDeath = Physics2D.OverlapCircle(myobj.position, radius, myLayer);
        if (isFallDeath)
        {
            rb.velocity = Vector2.zero;
            rb.position = tplocation.position;
        }
    }

    
}
