using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class characterAndEnviroment : MonoBehaviour
{
    // Start is called before the first frame update
    //0 = none
    //1 = truck
    //2 = lambo
    int SelectedV = 0;
    public Text LamboT;
    public Text TruckT;
    private GameObject musicObject;
    private float r, g, b;
     

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit select;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out select))
            {
                if (select.transform.name == "Truck" ) 
                {
                    SelectedV = 1;
                    TruckT.gameObject.SetActive(true);
                    LamboT.gameObject.SetActive(false);
                }
                else if (select.transform.tag == "Lambo")
                {
                    SelectedV = 2;
                    LamboT.gameObject.SetActive(true);
                    TruckT.gameObject.SetActive(false);
                }
            }
            Debug.Log(SelectedV);
        }
    }
    public void playGame()
    {
        if (SelectedV == 1)
        {
            PlayerPrefs.SetInt("ChosenCar", 1);
        }
        else
        {
            PlayerPrefs.SetInt("ChosenCar", 2);
        }
        musicObject = GameObject.FindWithTag("Music");
        Destroy(musicObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Just need to instantiate in next scene depending on click
}
