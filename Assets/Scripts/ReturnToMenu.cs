using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    public TimeAndCollect ti;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("escape"))
        {
            PressToContinue(); //is function because formerly in another script. Put it here for now
        }
    }

    void PressToContinue()
    {
        //ti.tim-= Time.time;
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
