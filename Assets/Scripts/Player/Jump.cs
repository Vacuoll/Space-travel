using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.PlayerLoop;

public class Jump : MonoBehaviour
{
    public float velocity;
    public Vector2 jump;
    public float yMin, yMax;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    public void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Stationary)
            {
                if(Input.touches[0].position.y > 188)
                    rb.AddForce(jump * velocity, ForceMode2D.Impulse);
                else
                    rb.AddForce(new Vector2(jump.x, -jump.y) * velocity, ForceMode2D.Impulse);
            }
        }

        rb.position = new Vector2(rb.position.x, Mathf.Clamp(rb.position.y, yMin, yMax));
        
        if(rb.position.y == yMax)
            rb.AddForce(new Vector2(0,-0.5f)*5, ForceMode2D.Impulse);
        if(rb.position.y == yMin)
            rb.AddForce(new Vector2(0,0.5f)*5, ForceMode2D.Impulse);
    }
}
