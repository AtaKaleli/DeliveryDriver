using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject menuScreen;
    [SerializeField] private GameObject howToPlayScreen;
    [SerializeField] private GameObject creditsScreen;
    [SerializeField] private GameObject levelSelectionScreen;
    [SerializeField] private GameObject levelInfoScreen;


    


    public void OnClickOpenHowToPlayScreen()
    {
        MenuAudio.instance.PlayButtonClick();
        menuScreen.SetActive(false);
        howToPlayScreen.SetActive(true);
    }

    public void OnClickOpenCreditsScreen()
    {
        MenuAudio.instance.PlayButtonClick();
        menuScreen.SetActive(false);
        creditsScreen.SetActive(true);
    }

    public void OnClickCloseHowToPlayScreen()
    {
        MenuAudio.instance.PlayButtonClick();
        menuScreen.SetActive(true);
        howToPlayScreen.SetActive(false);
    }

    public void OnClickCloseCreditsScreen()
    {
        MenuAudio.instance.PlayButtonClick();
        menuScreen.SetActive(true);
        creditsScreen.SetActive(false);
    }


    public void OnClickStartGame()
    {
        MenuAudio.instance.PlayButtonClick();
        menuScreen.SetActive(false);
        levelSelectionScreen.SetActive(true);
    }

    public void OnClickExitGame()
    {
        Application.Quit();
    }

    public void OnClickOpenLevelInfoScreen()
    {
        MenuAudio.instance.PlayButtonClick();
        levelSelectionScreen.SetActive(false);
        levelInfoScreen.SetActive(true);
    }

    public void OnClickCloseLevelInfoScreen()
    {
        MenuAudio.instance.PlayButtonClick();
        levelSelectionScreen.SetActive(true);
        levelInfoScreen.SetActive(false);
    }

    public void OnClickSelectEasyLevel()
    {
        
        GameUI.timeValue = 300;
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickSelectMediumLevel()
    {
        GameUI.timeValue = 220;
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickSelectHardLevel()
    {
        GameUI.timeValue = 160;
        SceneManager.LoadScene("GameScene");
    }

    public void OnClickSelectImpossibleLevel()
    {
        GameUI.timeValue = 100;
        SceneManager.LoadScene("GameScene");
    }


}
