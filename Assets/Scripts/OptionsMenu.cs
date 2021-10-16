using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public GameObject mainMenu, optionsMenu, howToPlayMenu;
    public Slider volumeSlider;

    void Start()
    {
        volumeSlider.value = AudioListener.volume;
    }

    public void back()
    {
        optionsMenu.SetActive(false);
        howToPlayMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void volume()
    {
        AudioListener.volume = volumeSlider.value;
        Debug.Log("Volume: " + AudioListener.volume);
        Debug.Log("Slider Value: " + volumeSlider.value);
    }
}
