using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu, optionsMenu, howToPlayMenu;

    //Play Button
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Options()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void HowToPlay()
    {
        mainMenu.SetActive(false);
        howToPlayMenu.SetActive(true);
    }
}
