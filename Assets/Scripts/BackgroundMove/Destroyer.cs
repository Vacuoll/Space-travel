using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject background;
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
           Destroy(background.gameObject);
    }
}
