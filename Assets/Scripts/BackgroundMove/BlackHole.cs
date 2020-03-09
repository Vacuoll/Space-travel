using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    private GameObject buttonsManager;
    public GameObject centerOfHole;
    private GameObject _player;
    public float forse;
    private bool _isPlayerNotNull;
    private Vector2 target = Vector2.zero;
    private MenuButtons _menuButtons;
    private Rigidbody2D rb;

    void Start()
    {
        buttonsManager = GameObject.FindGameObjectWithTag("Manager");
        _menuButtons = buttonsManager.GetComponent<MenuButtons>();
        _isPlayerNotNull = _player!=null;
        _player = GameObject.FindGameObjectWithTag("Player");
        rb = _player.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!_isPlayerNotNull && other.CompareTag("Player"))
        {
            target = centerOfHole.transform.position - _player.transform.position;
            rb.AddForce(target * forse);
        }
    }

    private void Update()
    {
        if (!_isPlayerNotNull && Vector2.Distance(_player.transform.position, centerOfHole.transform.position) < 1f)
        {
            _player.SetActive(false);
            //Destroy(_player.gameObject);
            _isPlayerNotNull = !_isPlayerNotNull;
            _menuButtons.isLose();
        }
    }
}
