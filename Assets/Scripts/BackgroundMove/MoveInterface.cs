using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInterface : MonoBehaviour
{
    private Camera _camera;
    public float speed;
    void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        speed = _camera.GetComponent<MoveCamera>().speed;
        gameObject.transform.Translate(Vector2.right * (Time.deltaTime * speed));
    }
}
