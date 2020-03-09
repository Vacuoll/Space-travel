using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject pauseIcon;
    public GameObject losePanel;
    public static bool GameIsPaused = false;
    public void FriendsButton()
    {
        SceneManager.LoadScene("Friends");
    }
    
    public void UniversesButton()
    {
        SceneManager.LoadScene("Universes");
    }
    public void JourneyButton()
    {
        int Cond_1_to_2 = PlayerPrefs.GetInt("Cond_1_to_2");
        int Cond_2_to_3 = PlayerPrefs.GetInt("Cond_2_to_3");
        
        int MaxScoreUniverse1 = PlayerPrefs.GetInt("Score1");
        int MaxScoreUniverse2 = PlayerPrefs.GetInt("Score2");
        
        if(MaxScoreUniverse1 < Cond_1_to_2)
            SceneManager.LoadScene("Universe1");
        else if (MaxScoreUniverse1 >= Cond_1_to_2 && MaxScoreUniverse1 < Cond_2_to_3)
            SceneManager.LoadScene("Universe2");
        else if (MaxScoreUniverse2 >= Cond_2_to_3)
            SceneManager.LoadScene("Universe3");
        
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        pauseIcon.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Training()
    {
        pausePanel.SetActive(false);
        pauseIcon.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void Continue()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        pauseIcon.SetActive(true);
        GameIsPaused = false;
    }

    public void isLose()
    {
        losePanel.SetActive(true);
        pauseIcon.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Repeat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        Back();
    }

    public void Universe1()
    {
        SceneManager.LoadScene("Universe1");
    }
    
    public void Universe2()
    {
        SceneManager.LoadScene("Universe2");
    }
    
    public void Universe3()
    {
        SceneManager.LoadScene("Universe3");
    }
}
