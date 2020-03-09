using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnLightPoint : MonoBehaviour
{
    public GameObject pointPref;
    public float StartTimeBtwStart;
    public float[] YSpawnPos;

    private float _timeBtwStart = 0;

    private void Update()
    {
        if (_timeBtwStart <= 0)
        {
            int rand = Random.Range(0, YSpawnPos.Length);
            Instantiate(pointPref, new Vector3(transform.position.x, YSpawnPos[rand], transform.position.z), Quaternion.identity);
            _timeBtwStart = StartTimeBtwStart;
        }
        else
        {
            _timeBtwStart -= Time.deltaTime;
        }
    }
}
