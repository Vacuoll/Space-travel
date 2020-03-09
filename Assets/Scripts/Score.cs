using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    public Text ScoreText;
    private int _score = 0;
    private float MaxScore;
    private string currentScene;
    private string currentScorePref;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        
        if (currentScene == "Universe1")
        {
            MaxScore = PlayerPrefs.GetInt("Score1");
            currentScorePref = "Score1";
        }
        else if (currentScene == "Universe2")
        {
            MaxScore = PlayerPrefs.GetInt("Score2");
            currentScorePref = "Score2";
        }
        else if (currentScene == "Universe3")
        {
            MaxScore = PlayerPrefs.GetInt("Score3");
            currentScorePref = "Score3";
        }
            
    }

    private void FixedUpdate()
    {
        if(_score > 0)
            ScoreText.text = _score + " световых лет";
        _score = 500 + (int) (transform.position.x * 100);
        if(_score > MaxScore)
            PlayerPrefs.SetInt(currentScorePref, _score);
        
    }
}
