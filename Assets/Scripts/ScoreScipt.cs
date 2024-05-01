using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreScipt : MonoBehaviour
{
    public TextMeshProUGUI txt;
    private int start_score = 0;
    public int current_score;

    // Start is called before the first frame update
    void Start()
    {
        current_score = start_score;
        UpdateScore();
    }

    public void IncreaseScore()
    {
        current_score++;
        UpdateScore();
    }

    // Update the displayed score
    void UpdateScore()
    {
        txt.text = "Score: " + current_score.ToString();
    }
}
