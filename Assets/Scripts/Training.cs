using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    private string IsItFirstGame ;
    public GameObject instruction1;
    public GameObject instruction2;
    public GameObject touchIconUp;
    public GameObject touchIconDown;
    public GameObject FirstPrefabEnemy;

    private void Start()
    {
         IsItFirstGame = PlayerPrefs.GetString("IsItFirstGame");
        
        if (IsItFirstGame != "false")
        {
            StartCoroutine("Preparation");
        }
        else
        {
            FirstPrefabEnemy.transform.position -= new Vector3(20f, 0,0);
        }
    }

    IEnumerator Preparation()
    {
        instruction1.SetActive(true);
        touchIconUp.SetActive(true);
        yield return new WaitForSeconds(4f);
        instruction1.SetActive(false);
        touchIconUp.SetActive(false);
        instruction2.SetActive(true);
        touchIconDown.SetActive(true);
        yield return new WaitForSeconds(4f);
        instruction2.SetActive(false);
        touchIconDown.SetActive(false);
        IsItFirstGame = "false";
        PlayerPrefs.SetString("IsItFirstGame", IsItFirstGame.ToString());
    }

}
