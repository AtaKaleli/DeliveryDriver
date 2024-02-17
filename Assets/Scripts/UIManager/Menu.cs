using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject menuScreen;
    [SerializeField] private GameObject howToPlayScreen;
    [SerializeField] private GameObject creditsScreen;
    


    void OnClickOpenHowToPlayScreen()
    {
        menuScreen.SetActive(false);
        howToPlayScreen.SetActive(true);
    }

    void OnClickOpenCreditsScreen()
    {
        menuScreen.SetActive(false);
        creditsScreen.SetActive(true);
    }

    void OnClickCloseHowToPlayScreen()
    {
        menuScreen.SetActive(true);
        howToPlayScreen.SetActive(false);
    }

    void OnClickCloseCreditsScreen()
    {
        menuScreen.SetActive(true);
        howToPlayScreen.SetActive(false);
    }


    void OnClickStartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    void OnClickExitGame()
    {
        Application.Quit();
    }





}
