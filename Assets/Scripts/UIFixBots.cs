using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIFixBots : MonoBehaviour
{
    public static UIFixBots instance { get; private set;}
    public TMPro.TextMeshProUGUI fixedRobotsText;
    public TMPro.TextMeshProUGUI endGameText;
    private int numberOfFixedBots = 0;
    private int maxRobots;
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        fixedRobotsText.text = " Fixed Robots is : " + numberOfFixedBots.ToString();;
    }

    public void addValue(int value)
    {				      
        numberOfFixedBots = numberOfFixedBots + value;
        fixedRobotsText.text = " Fixed Robots is : " + numberOfFixedBots.ToString();
        if(numberOfFixedBots == maxRobots){
            endGameText.text = "WOW you WON HOWIE\n Press R to restart";
            Time.timeScale = 0;
        }
    }

    public void deadFox(){
        endGameText.text = "WOW you Lost HOWIE\n Press R to restart";
        Time.timeScale = 0;
    }

    public void incrementMaxValue()
    {
        maxRobots = maxRobots+1;
    }
}
