using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SpawnBackground : MonoBehaviour
{
    public Transform Points;
    public GameObject Prefab;
    public Transform Canvas;
    private float prevSpeed;
    

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject A = Instantiate(Prefab, Points.position, Quaternion.identity);
            A.transform.SetParent(Canvas, false);
            Destroy(gameObject);
        }

    }

}

