using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text ScoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void addScore(int newScore)
    {
        score = score + newScore;
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }
}
