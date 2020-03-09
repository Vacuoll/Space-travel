using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public Text ScoreUniverse1;
    private int MaxScoreUniverse1;
    
    public Text ScoreUniverse2;
    private int MaxScoreUniverse2;
    public GameObject BlockPanel2;
    public GameObject Text2;
    
    public Text ScoreUniverse3;
    private int MaxScoreUniverse3;
    public GameObject BlockPanel3;
    public GameObject Text3;
    private int Cond_1_to_2 = 50000;
    private int Cond_2_to_3 = 100000;
    void Start()
    {
        PlayerPrefs.SetInt("Cond_1_to_2", Cond_1_to_2);
        PlayerPrefs.SetInt("Cond_2_to_3", Cond_2_to_3);
        
        MaxScoreUniverse1 = PlayerPrefs.GetInt("Score1");
        MaxScoreUniverse2 = PlayerPrefs.GetInt("Score2");
        MaxScoreUniverse3 = PlayerPrefs.GetInt("Score3");
        
        ScoreUniverse1.text = MaxScoreUniverse1 + " световых лет";
        if (MaxScoreUniverse1 >= Cond_1_to_2 && MaxScoreUniverse1 < Cond_2_to_3)
        {
            UnlockUniverse2();
        }
        
        if (MaxScoreUniverse2 + MaxScoreUniverse1>= Cond_2_to_3)
        {
            UnlockUniverse3();
        }
        
    }

    public void UnlockUniverse2()
    {
        BlockPanel2.SetActive(false);
        Text2.gameObject.SetActive(true);
        ScoreUniverse2.gameObject.SetActive(true);
        ScoreUniverse2.text = MaxScoreUniverse2 + " световых лет";
        
    }

    public void UnlockUniverse3()
    {
        BlockPanel3.SetActive(false);
        Text3.SetActive(true);
        ScoreUniverse3.gameObject.SetActive(true);
        ScoreUniverse3.text = MaxScoreUniverse3 + " световых лет";  
    }

}
