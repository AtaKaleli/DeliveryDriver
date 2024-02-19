using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameUI : MonoBehaviour
{

    public static GameUI instance;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI remainingPackeges;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TextMeshProUGUI gameOverInformation;

    
    
    
    
    public static float timeValue;
    private float gameTimer;

    
    


    private void Awake()
    {
        gameTimer = timeValue;
        instance = this;
        Time.timeScale = 1;
    }




    private void Update()
    {

        gameTimer -= Time.deltaTime;
        timerText.text = gameTimer.ToString("#,#");
        if (gameTimer <= 0)
        {
            EndGame();
            GameAudio.instance.MuteBackgroundAudio();
            gameOverInformation.text = "You failed!\n\nYou could not have delivered packages on time!";
            
        }

    }

    public void ShowRemainingPackeges(int packetNo)
    {
        remainingPackeges.text = packetNo.ToString();
    }

    public void OnClickRestartGame()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;

    }
    
    public void OnClickExitGame()
    {
        Application.Quit();
    }

    public void OnClickReturnMenu()
    {
        gameOverPanel.SetActive(false);
        SceneManager.LoadScene("OpeningScene");
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void GameOverInformation(string text)
    {
        EndGame();
        gameOverInformation.text = text;
    }

    

}
