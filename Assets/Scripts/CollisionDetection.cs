using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    public VictoryLine Score; 
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Flags")
        {
            Score.scoreModifier = 1000;
            Destroy(other.gameObject);
            Score.AddScore();
        }else if(other.tag == "Cone")
        {
            Score.scoreModifier = -100;
            Destroy(other.gameObject);
            Score.AddScore();
        }else if( other.gameObject.tag == "Pothole")
        {
            Score.scoreModifier = -500;
            Destroy(other.gameObject);
            Score.AddScore();
        }
    }
}
