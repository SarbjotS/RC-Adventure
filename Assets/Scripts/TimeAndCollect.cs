using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeAndCollect : MonoBehaviour
{
    public Text TimerText;
    public float tim;

    void Start()
    {
        TimerText.text = tim.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            tim = Time.timeSinceLevelLoad;
            TimerText.text = tim.ToString();

        }
        else
        {
            TimerText.text = "0";
        }
        if (Input.GetKeyDown(KeyCode.Escape)){
            //tim-=Time.time;
        }
        
    }

    public float GetTimer()
    {
        return tim;
    }
}
