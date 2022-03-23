using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class TimeManager : MonoBehaviour
{

    Image timerBar;
    public float maxTime = 5f;
    float timeLeft;
    public GameObject timesUpText;
    public GameObject button;

    void Start()
    {
        timesUpText.SetActive(false); //시작할때 안보이도록 하기 
        button.SetActive(false); 
        timerBar = GetComponent<Image>(); // timeBar는 image
        timeLeft = maxTime; 
    }


    void Update()
    {
        if (timeLeft > 0)  //timeLeft가 0보다 크다면
        {
            timeLeft -= Time.deltaTime;  //계속해서 시간이 줄어든다.
            timerBar.fillAmount = timeLeft / maxTime;  //타임바의 감소
        }
        else {
            timesUpText.SetActive(true);
            button.SetActive(true);
            Time.timeScale = 0;
        }
                 
        
    }
}
