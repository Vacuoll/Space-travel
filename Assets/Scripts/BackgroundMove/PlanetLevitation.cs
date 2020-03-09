using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetLevitation : MonoBehaviour
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
        endPos = new Vector2(transform.position.x, transform.position.y + delta);
    }

    void Update()
    {
        if (Time.time > deltatime)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        

        if (transform.position == target && target.y != startPos.y)
            target.y = startPos.y;
        else if (transform.position == target && target.y == startPos.y)
            target.y = endPos.y;
        }
    }
}
