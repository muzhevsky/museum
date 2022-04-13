using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    [SerializeField] float timeLimit = 20;
    [SerializeField] public float timeLeft = 20;
    [SerializeField] GameBlock block;
    Text text;
    bool timerIsTicking = false;
    public float spentTime = 0f;
    private void Start()
    {
        text = GetComponent<Text>();
    }
    private void Update()
    {
        if (timerIsTicking)
        {
            timeLeft -= Time.deltaTime;
            text.text = Math.Round(timeLeft, 1).ToString();
            if (timeLeft <= 0)
            {
                block.OnFalseAnswer();
                timeLeft = 0;
                text.text = timeLeft.ToString();
                timerIsTicking = false;
            }
        }
    }
    public void ResetTimer()
    {
        StopTimer();
        timeLeft = timeLimit;
    }
    public void ResetTimerFull()
    {
        StopTimer();
        timeLeft = timeLimit;
        spentTime = 0f;
    }
    public void CountTime()
    {
        spentTime += timeLimit - timeLeft;
        ResetTimer();
    }
    public void StartTimer()
    {
        timerIsTicking = true;
    }
    public void StopTimer()
    {
        timerIsTicking = false;
    }
}
