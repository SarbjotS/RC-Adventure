using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeAndCollect : MonoBehaviour
{
    public Text TimerText;
    float tim;

    void Start()
    {
        tim -= Time.time;
        TimerText.text = tim.ToString();
        tim += Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            tim = Time.time;
            TimerText.text = tim.ToString();
            Debug.Log(SceneManager.GetActiveScene().buildIndex);

        }
        else
        {
            TimerText.text = "0";
        }
    }
}
