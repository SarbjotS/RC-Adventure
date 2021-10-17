using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryLine : MonoBehaviour
{
    public GameObject VictoryText;
    public TimeAndCollect Timer; 
    public GameObject ContinueButton;
    public GameObject ScoreContainer;
    public Text scoreText;

    private float TimeTaken = 0.0f;
    private float Score = 0.0f;

    void OnTriggerEnter()
    {
        VictoryText.SetActive(true);
        TimeTaken = Timer.GetTimer();
        Score = 12000.0f - (TimeTaken*100.0f);
        scoreText.text = Score.ToString();
        ScoreContainer.SetActive(true);
        ContinueButton.SetActive(true);
        Destroy(this.gameObject);
    }
}
