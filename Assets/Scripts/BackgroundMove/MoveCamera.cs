using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveCamera : MonoBehaviour
{
    public float speed = 0.004f;
    private GameObject _player;
    public bool speedUp;
    public bool speedDown;

    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (_player)
        {
            gameObject.transform.Translate(Vector2.right * Time.deltaTime * speed);
            if (gameObject.CompareTag("MainCamera"))
            {
                if (transform.position.x - _player.transform.position.x < -1f)
                    speedUp = true;
                if (transform.position.x - _player.transform.position.x > 0)
                    speedDown = true;

            }
            if (speedUp)
            {
                speed += 0.05f;
                speedUp = false;
            }
            if (speedDown)
            {
                if (speed > 3)
                {
                    speed -= 0.1f;
                    speedDown = false;
                }
            }
        }
        
    }
}
