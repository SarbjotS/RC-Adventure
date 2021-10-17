
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
    public float scoreModifier = 0;

    public void AddScore()
    {
        Score = Score + scoreModifier;
        //Debug.Log("Score Added or Detracted");
    }

    void OnTriggerEnter()
    {
        VictoryText.SetActive(true); //reveal UI
        TimeTaken = Timer.GetTimer(); //get Time from the Timer script
        Score = Score + 12000.0f - (TimeTaken*100.0f); //calculate score
        scoreText.text = Score.ToString(); //display score
        ScoreContainer.SetActive(true);
        ContinueButton.SetActive(true); //reveal rest of UI
        Destroy(this.gameObject); //destroy object to ensure it doesn't repeat
    }
}
