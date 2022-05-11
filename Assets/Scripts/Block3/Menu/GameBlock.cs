using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBlock : Block
{
    [SerializeField] GlobalUIController controller;
    [SerializeField] GameObject LoseScreen;
    [SerializeField] GameObject WinScreen;
    [SerializeField] GameObject PauseScreen;
    [SerializeField] GameObject StartScreen;
    [SerializeField] GameObject quizContainer;
    [SerializeField] GameObject activeScreen;
    [SerializeField] Timer onScreenTimer;
    [SerializeField] QuizController quizController;
    [SerializeField] Block nextBlock;
    [SerializeField] AnimationController animationController;
    [SerializeField] float waitTime;
    public void OnRightAnswer()
    {
        animationController.OnVictory();
        quizController.gameObject.SetActive(false);
        onScreenTimer.CountTime();
    }
    public void OnFalseAnswer()
    {
        animationController.OnDefeat();
        quizController.gameObject.SetActive(false);
        onScreenTimer.CountTime();
    }
    public virtual void OnFalseAnswer(int answerNumber)
    {
        animationController.OnDefeat(answerNumber);
        quizController.gameObject.SetActive(false);
        onScreenTimer.CountTime();
    }
    public void OnRightAnswer(int answerNumber)
    {
        animationController.OnVictory(answerNumber);
        quizController.gameObject.SetActive(false);
        onScreenTimer.CountTime();
    }
    public void OnNextQuestion()
    {
        activeScreen.SetActive(false);
        onScreenTimer.StartTimer();

        if (!quizController.QuizIsOver())
        {
            StartGame();
        }
        else
        {
            LoadNextLevel();
        }
    }
    public void Win()
    {
        WinScreen.SetActive(true);
        activeScreen = WinScreen;
    }
    public void Lose()
    {
        LoseScreen.SetActive(true);
        activeScreen = LoseScreen;
    }
    public void LoadNextLevel()
    {
        StopGame();
        controller.LoadBlock(nextBlock);
    }
    public void RestartGame()
    {
        onScreenTimer.ResetTimer();
        quizController.RestartQuiz();
        StartGame();
    }
    public void StartGame()
    {
        onScreenTimer.StartTimer();
        activeScreen.SetActive(false);
        quizContainer.SetActive(true);
        StartCoroutine(DelayBeforeStart());
        animationController.OnSetup(quizController.GetQuestionNumber());
    }
    IEnumerator DelayBeforeStart()
    {
        yield return new WaitForSeconds(waitTime);
        quizController.gameObject.SetActive(true);
        quizController.StartQuiz();

    }
    public void PauseGame()
    {
        PauseScreen.SetActive(true);
        quizController.gameObject.SetActive(false);
        activeScreen = PauseScreen;
        onScreenTimer.StopTimer();
        animationController.OnPause();
    }
    public void UnpauseGame()
    {
        quizController.gameObject.SetActive(true);
        activeScreen.SetActive(false);
        onScreenTimer.StartTimer();
        animationController.OnUnpause();
    }
    public void StopGame()
    {
        onScreenTimer.ResetTimer();
        activeScreen.SetActive(false);
        StartScreen.SetActive(true);
        activeScreen = StartScreen;
        quizContainer.SetActive(false);
        quizController.gameObject.SetActive(false);
        quizController.OnWin();
        animationController.OnSetup(quizController.GetQuestionNumber());
    }
}