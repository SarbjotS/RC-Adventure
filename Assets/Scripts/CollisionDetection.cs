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
            Score.scoreModifier = 10000000000;
            Destroy(other.gameObject);
        }else if(other.tag == "Cone")
        {
            Destroy(other.gameObject);
        }else if( other.gameObject.tag == "Pothole")
        {
            Destroy(other.gameObject);
        }
    }
}
