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
    private void Update()
    {
        if (timerIsTicking)
        {
            timeLeft -= Time.deltaTime;
            onScreenTimer.text = Math.Round(timeLeft,2).ToString();
        }
        if (timeLeft < 0)
        {
            timeLeft = 0;
            onScreenTimer.text = timeLeft.ToString();
        }
    }
    public void OnRightAnswer()
    {
        WinScreen.SetActive(true);
        activeScreen = WinScreen;
        timerIsTicking = false;
    }
    public void OnFalseAnswer()
    {
        LoseScreen.SetActive(true);
        activeScreen = LoseScreen;
        quizContainer.SetActive(false);
        timerIsTicking = false;
    }
    public void OnNextQuestion()
    {
        activeScreen.SetActive(false);
        timerIsTicking = true;
        timeLeft = timeLimit;
        quizController.StartQuiz();
    }
    public void LoadNextLevel()
    {
        StopGame();
        controller.LoadBlock(nextBlock);
    }
    public void RestartGame()
    {
        activeScreen.SetActive(false);
        quizContainer.SetActive(false);
        activeScreen = StartScreen;
        activeScreen.SetActive(true);
        timerIsTicking = false;
        timeLeft = timeLimit;
        quizController.RestartQuiz();
    }
    public void StartGame()
    {
        timerIsTicking = true;
        timeLeft = timeLimit;
        activeScreen.SetActive(false);
        quizContainer.SetActive(true);
        quizController.StartQuiz();
    }
    public void PauseGame()
    {
        PauseScreen.SetActive(true);
        quizContainer.SetActive(false);
        activeScreen = PauseScreen;
        timerIsTicking = false;
    }
    public void UnpauseGame()
    {
        quizContainer.SetActive(true);
        activeScreen.SetActive(false);
        timerIsTicking = true;
    }
    public void StopGame()
    {
        timerIsTicking=false;
        timeLeft = timeLimit;
        activeScreen.SetActive(false);
        StartScreen.SetActive(true);
        activeScreen = StartScreen;
        quizController.RestartQuiz();
    }

}
