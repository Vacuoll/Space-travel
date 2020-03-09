using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudLevitation : MonoBehaviour
{
    public float speed = 0.1f;
    public float delta = 0.1f;
    public float deltatime;
    private Vector3 target;

    private Vector2 startPos;
    private Vector2 endPos;

    void Start()
    {
        target = transform.position;
        startPos = transform.position;
        endPos = new Vector2(transform.position.x + delta, transform.position.y);
    }

    void Update()
    {
        if (Time.time > deltatime)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        

            if (transform.position == target && target.x != startPos.x)
                target.x = startPos.x;
            else if (transform.position == target && target.x == startPos.x)
                target.x = endPos.x;
        }
    }
}
