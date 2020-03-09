using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    private Animator anim;
    
    private float _timer = 17f;
    private float updateTime;
    
    private GameObject _player;
    private bool _isTrigger;
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
        anim = _player.GetComponent<Animator>();
        updateTime = _timer;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _isTrigger = true;
        if (other.CompareTag("Player"))
        {
            anim.SetBool("isTrigger", true);
        }
    }
    private void FixedUpdate()
    {
        if (_isTrigger)
        {
            updateTime -= Time.fixedDeltaTime;
            if (updateTime < 0)
            {
                anim.SetBool("isTrigger", false);
                _isTrigger = !_isTrigger;
                updateTime = _timer;
            }
        }
    }
}
