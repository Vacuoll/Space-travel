using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class FriendsUnlock : MonoBehaviour
{
    public Button selectButton1;
    public Button selectButton2;
    public Button selectButton3;
    public GameObject select2;
    public GameObject select1;
    public GameObject select3;
    public GameObject condition1;
    public GameObject condition2;
    private int totalScore;
    public Text totalScoreText;
    public int cond1;
    public int cond2;
    private bool unlock1friend = false;
    private bool unlock2friend = false;
    private int pref;

    private void Awake()
    {
        pref = PlayerPrefs.GetInt("PlayerPref");
        if (pref == 1)
            Select1();
        if (pref == 2)
            Select2();
        if (pref == 3)
            Select3();
    }

    void Start()
    {
       totalScore = PlayerPrefs.GetInt("Score") + PlayerPrefs.GetInt("Score2") + PlayerPrefs.GetInt("Score3");
       totalScoreText.text = "Всего преодолено " + totalScore + " световых лет";
        if (totalScore > cond1)
        {
            UnlockFriend(1);
            unlock1friend = true;
        }
        if (totalScore > cond2)
        {
            UnlockFriend(2);
            unlock2friend = true;
        }
    }

    public void UnlockFriend(int i)
    {
        if (i == 1)
        {
            condition1.SetActive(false);
            if(pref!=2)
              selectButton2.gameObject.SetActive(true);
        }
        if (i == 2)
        {
            condition2.SetActive(false);
            if(pref!=3)
            selectButton3.gameObject.SetActive(true);
        }
    }

    public void Select1()
    {
        select1.SetActive(true);
        select2.SetActive(false);
        select3.SetActive(false);
        selectButton1.gameObject.SetActive(false);
        if(unlock1friend)
            selectButton2.gameObject.SetActive(true);
        if(unlock2friend)
            selectButton3.gameObject.SetActive(true);
        PlayerPrefs.SetInt("PlayerPref", 1);
    }
    public void Select2()
    {
        select2.SetActive(true);
        select1.SetActive(false);
        select3.SetActive(false);
        selectButton2.gameObject.SetActive(false);
        selectButton1.gameObject.SetActive(true);
        if(unlock2friend)
            selectButton3.gameObject.SetActive(true);
        PlayerPrefs.SetInt("PlayerPref", 2);
    }
    public void Select3()
    {
        select3.SetActive(true);
        select2.SetActive(false);
        select1.SetActive(false);
        selectButton3.gameObject.SetActive(false);
        selectButton2.gameObject.SetActive(true);
        selectButton1.gameObject.SetActive(true);
        PlayerPrefs.SetInt("PlayerPref", 3);
    }
}
