using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{

    public static GameUI instance;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private TextMeshProUGUI remainingPackeges;
    [SerializeField] private TextMeshProUGUI showInfo;



    private float timeValue;


    private void Awake()
    {
        instance = this;
        timeValue = 0;
    }




    private void Update()
    {

        timeValue += Time.deltaTime;

        if (timeValue >= 1)
        {
            timerText.text = timeValue.ToString("#,#");
        }

    }

    public void ShowRemainingPackeges(int packetNo)
    {
        remainingPackeges.text = packetNo.ToString();
    }

    public void ShowInfo(string info)
    {
        showInfo.text = info;
    }

}
