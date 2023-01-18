using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public static score instance;
    public TextMeshProUGUI scoreTxt;
    public TextMeshProUGUI HighscoreTxt;


    int s = 0;
    int h = 0;
    private void Awake()
    {
        instance = this; 
    
    }
    void Start()
    {
        h = PlayerPrefs.GetInt("h", 0);
        scoreTxt.text = "POINTS: " + s;
        HighscoreTxt.text = "HIGHSCORE: " + h;
    }


    public void AddPoints()
    {
        s += 1;
        scoreTxt.text = s.ToString() + " POINTS";
        if (h < s)
            PlayerPrefs.SetInt("h", s);
    }
}
