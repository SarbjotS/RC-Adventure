using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadCarSelection : MonoBehaviour
{
    public GameObject Truck;
    public GameObject Lambo;
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
        }
        else
        {
            Truck.SetActive(false);
        }
    }

}
