using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBlock : Block
{
    [SerializeField] GlobalUIController controller;
    [SerializeField] float timeLimit = 20;
    [SerializeField] float timeLeft = 20;
    [SerializeField] GameObject LoseScreen;
    [SerializeField] GameObject WinScreen;
    [SerializeField] GameObject PauseScreen;
    [SerializeField] GameObject StartScreen;
    [SerializeField] GameObject quizContainer;
    [SerializeField] GameObject activeScreen;
    [SerializeField] Text onScreenTimer;
    [SerializeField] QuizController quizController;
    [SerializeField] GameBlock nextBlock;
    bool timerIsTicking = false;
    public void OnRightAnswer()
    {
        WinScreen.SetActive(true);
        activeScreen = WinScreen;
        timerIsTicking = false;
        StopCoroutine(Timer());
    }
    public void OnFalseAnswer()
    {
        LoseScreen.SetActive(true);
    }
    public void OnNextQuestion()
    {
        activeScreen.SetActive(false);
        timerIsTicking = true;
        timeLeft = timeLimit;
        StartCoroutine(Timer());
        quizController.StartQuiz();
    }
    public void LoadNextLevel()
    {
        controller.LoadBlock(nextBlock);
    }
    public void RestartGame()
    {
        activeScreen.SetActive(false);
        timerIsTicking = true;
        timeLeft = timeLimit;
        StartCoroutine(Timer());
        quizController.RestartQuiz();
    }
    IEnumerator Timer()
    {
        onScreenTimer.text = Math.Round(timeLeft, 2).ToString();    
        while (timerIsTicking)
        {
            yield return new WaitForSeconds(0.05f);
            timeLeft-=0.05f;
            if (timeLeft <= 0)
            {
                LoseScreen.SetActive(true);
                activeScreen = LoseScreen;
                break;
            }
            onScreenTimer.text = Math.Round(timeLeft, 2).ToString();
        }
        onScreenTimer.text = Math.Round(timeLeft,2).ToString();
        timerIsTicking = false;
    }
    public void StartGame()
    {
        timerIsTicking = true;
        timeLeft = timeLimit;
        StartCoroutine(Timer());
        activeScreen.SetActive(false);
        quizContainer.SetActive(true);
        quizController.StartQuiz();
    }
    public void PauseGame()
    {
        PauseScreen.SetActive(true);
        activeScreen = PauseScreen;
        timerIsTicking = false;
        StopCoroutine(Timer());
    }
    public void UnpauseGame()
    {
        activeScreen.SetActive(false);
        timerIsTicking = true;
        StartCoroutine(Timer());
    }
}
