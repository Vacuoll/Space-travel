using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPrefab : MonoBehaviour
{
    public GameObject Pref1;
    public GameObject Pref2;
    public GameObject Pref3;
    private int pref;
    void Start()
    {
        pref = PlayerPrefs.GetInt("PlayerPref");
        if (pref == 1)
        {
            Pref1.SetActive(true);
            Pref2.SetActive(false);
            Pref3.SetActive(false);
        }
        if (pref == 2)
        {
            Pref2.SetActive(true);
            Pref1.SetActive(false);
            Pref3.SetActive(false);
        }
        if (pref == 3)
        {
            Pref3.SetActive(true);
            Pref2.SetActive(false);
            Pref1.SetActive(false);
        }
    }

}
