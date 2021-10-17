
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
    void OnTriggerEnter()
    {
<<<<<<< Updated upstream
        VictoryText.SetActive(true);
        TimeTaken = Timer.GetTimer();
        Score = 12000.0f - (TimeTaken*100.0f);
        Score += scoreModifier;
        scoreText.text = Score.ToString();
=======
        VictoryText.SetActive(true); //reveal UI
        TimeTaken = Timer.GetTimer(); //get Time from the Timer script
        Score = 12000.0f - (TimeTaken*100.0f); //calculate score
        scoreText.text = Score.ToString(); //display score
>>>>>>> Stashed changes
        ScoreContainer.SetActive(true);
        ContinueButton.SetActive(true); //reveal rest of UI
        Destroy(this.gameObject); //destroy object to ensure it doesn't repeat
    }
}
