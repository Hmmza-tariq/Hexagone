using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreTxt;
    public int score;
    private float timer = 0;
    void Start()
    {
        score = 25;
    }
    void Update()
    {
        /*       score = (int) player.position.z;
              */
        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            score++;
            timer = 0;
        }
        scoreTxt.text = score.ToString();
    }
}
