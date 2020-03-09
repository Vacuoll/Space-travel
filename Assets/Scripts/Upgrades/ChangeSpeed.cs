using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class ChangeSpeed : MonoBehaviour
{
    private float change = 0.05f;
    private float changeCamera = 3f;
    private Vector2 _jumpChange = new Vector2(1f,1f);
    private Camera _camera;
    public GameObject background;
    public GameObject _interface;
    
    public float _timer = 4f;
    private float updateTime;
    private GameObject _player;
    private bool _isTrigger;
    private Jump _jump;
    //private Move _move;
  //  private Move backgroundMove;
  //  private Move interfaceMove;

    private void Start()
    {
        _camera = Camera.main;
     //   if (_camera != null) _move = _camera.GetComponent<Move>();

      //  backgroundMove = background.GetComponent<Move>();
      //  interfaceMove = _interface.GetComponent<Move>();
        
        _player = GameObject.FindWithTag("Player");
        _jump = _player.GetComponent<Jump>();
        
        updateTime = _timer;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.CompareTag("Player"))
        {
            _isTrigger = true;
            other.GetComponent<Jump>().velocity += change;
            other.GetComponent<Jump>().jump += _jumpChange;
         //   _move.speed += changeCamera;
          //  backgroundMove.speed += changeCamera;
         //   interfaceMove.speed += changeCamera;
        }
    }

    private void FixedUpdate()
    {
        if (_isTrigger)
        {
            updateTime -= Time.fixedDeltaTime;
            if (updateTime < 0)
            {
                _jump.velocity -= change;
                _jump.jump -= _jumpChange;
              //  _move.speed -= changeCamera;
               // backgroundMove.speed -= changeCamera;
              //  interfaceMove.speed -= changeCamera;
                updateTime = _timer;
                _isTrigger = !_isTrigger;
            }
        }
    }

}
