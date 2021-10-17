using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadCarSelection : MonoBehaviour
{
    public GameObject Truck;
    public GameObject Lambo;
    public Canvas TimeCanvas;
    // Start is called before the first frame update
    void Start()
    {
        loadPlayerCar();
    }

    // Update is called once per frame
    void loadPlayerCar()
    {
        if (PlayerPrefs.GetInt("ChosenCar") == 1)
        {
            Lambo.SetActive(false);
            TimeCanvas.transform.parent = Truck.transform;
        }
        else
        {
            Truck.SetActive(false);
            TimeCanvas.transform.parent = Lambo.transform;

        }
    }

}
