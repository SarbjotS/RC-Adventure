using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        Score = 12000 - (TimeTaken*100);
        scoreText.text = "Score: " + Score.ToString() + "Test!";
        ScoreContainer.SetActive(true);
        ContinueButton.SetActive(true);
    }

    public void PressToContinue()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
