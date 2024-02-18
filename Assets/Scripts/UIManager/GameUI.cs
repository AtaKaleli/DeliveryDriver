using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameUI : MonoBehaviour
{

    public static GameUI instance;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI remainingPackeges;
    
    public static float timeValue;


    
    


    private void Awake()
    {
        instance = this;
        timeValue = 10000;
    }




    private void Update()
    {

        timeValue -= Time.deltaTime;
        timerText.text = timeValue.ToString("#,#");
        if (timeValue <= 0)
            Time.timeScale = 0;

    }

    public void ShowRemainingPackeges(int packetNo)
    {
        remainingPackeges.text = packetNo.ToString();
    }

    

}
