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

    [SerializeField] private Animator deliveryPointAnim;
    [SerializeField] private Animator arrowSignTopAnim;
    [SerializeField] private Animator arrowSignBottomAnim;
    [SerializeField] private GameObject levelLoader;
    
    
    
    public static float timeValue;
    private float gameTimer;
    public bool gameEnd = false;
    
    


    private void Awake()
    {
        
        gameTimer = timeValue;
        instance = this;
        Time.timeScale = 1;
    }

    


    private void Update()
    {
        if(!gameEnd)
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
        levelLoader.SetActive(true);
        LevelLoader.instance.MoveMenu();
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

   

    public void DeliveryPointAnim(bool packageStatus) => deliveryPointAnim.SetBool("PackageTaken", packageStatus);
    public void ArrowSignTopAnim(bool packageStatus) => arrowSignTopAnim.SetBool("PackageTaken", packageStatus);
    public void ArrowSignBottomAnim(bool packageStatus) => arrowSignBottomAnim.SetBool("PackageTaken", packageStatus);
    

}
