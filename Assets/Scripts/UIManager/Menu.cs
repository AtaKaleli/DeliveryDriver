using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject menuScreen;
    [SerializeField] private GameObject howToPlayScreen;
    [SerializeField] private GameObject creditsScreen;
    


    public void OnClickOpenHowToPlayScreen()
    {
        menuScreen.SetActive(false);
        howToPlayScreen.SetActive(true);
    }

    public void OnClickOpenCreditsScreen()
    {
        menuScreen.SetActive(false);
        creditsScreen.SetActive(true);
    }

    public void OnClickCloseHowToPlayScreen()
    {
        menuScreen.SetActive(true);
        howToPlayScreen.SetActive(false);
    }

    public void OnClickCloseCreditsScreen()
    {
        menuScreen.SetActive(true);
        creditsScreen.SetActive(false);
    }


    public void OnClickStartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickExitGame()
    {
        Application.Quit();
    }





}
