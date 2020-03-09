using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.PlayerLoop;


public class Rotation : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.rotation = 360;
    }
}
