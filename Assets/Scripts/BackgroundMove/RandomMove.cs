using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomMove : MonoBehaviour
{
    private float tilt;
    private Vector2 randomVec;
    private float speed;
    private Rigidbody2D rb;
    private bool isContact = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        speed = Random.Range(0.01f, 0.2f);
        tilt = Random.Range(0.05f, 0.1f);
        randomVec = new Vector2(Random.Range(-0.3f, 0.3f), Random.Range(-0.3f, 0.3f));
    }

    void FixedUpdate()
    {
        if (!isContact)
        {
            rb.velocity = randomVec * speed;
            transform.Rotate(Vector3.back * tilt);
        }
        else
        {
            rb.gravityScale = 0;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider)
            isContact = true;
        else if (!other.collider)
            isContact = false;
    }
}
