using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBlock : Block
{

    [SerializeField] protected GameBlock nextGameBlock;
    [SerializeField] protected Block winBlock;

    [SerializeField] protected GlobalUIController controller;
    [SerializeField] protected AnimationController animationController;
    [SerializeField] protected QuizController quizController;

    [SerializeField] protected WindowInfo windowInfo;
    [SerializeField] protected GameObject overlay;
    [SerializeField] protected GameObject quizContainer;
    [SerializeField] protected Timer onScreenTimer;

    [SerializeField] protected float waitTime;
    [SerializeField] protected Block beforeGameStartsBlock;

    [SerializeField] bool startWindowFlag = false;
    public Block GetBeforeGameStartsBlock()
    {
        return beforeGameStartsBlock;
    }
    public WindowInfo GetWindowInfo()
    {
        return windowInfo;
    }
    public virtual void OnRightAnswer()
    {
        overlay.SetActive(true);
        animationController.OnVictory();
        quizController.gameObject.SetActive(false);
        onScreenTimer.CountTime();
    }
    public virtual void OnFalseAnswer()
    {
        overlay.SetActive(true);
        animationController.OnDefeat();
        quizController.gameObject.SetActive(false);
        onScreenTimer.CountTime();
    }
    public virtual void OnFalseAnswer(int answerNumber)
    {
        overlay.SetActive(true);
        animationController.OnDefeat(answerNumber);
        quizController.gameObject.SetActive(false);
        onScreenTimer.CountTime();
    }
    public virtual void OnRightAnswer(int answerNumber)
    {
        overlay.SetActive(true);
        animationController.OnVictory(answerNumber);
        quizController.gameObject.SetActive(false);
        onScreenTimer.CountTime();
    }
    public virtual void OnNextQuestion()
    {
        controller.HideActiveWindow();
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
        if (quizController.QuizIsOver() && nextGameBlock == null)
        {
            StopGame();
            controller.LoadBlock(winBlock);
        }
        else controller.OpenWindow(Windows.winWindow);
    }
    public void Lose()
    {
        controller.OpenWindow(Windows.loseWindow);
    }
    public void LoadNextLevel()
    {
        controller.HideActiveWindow();
        StopGame();
        if (nextGameBlock != null) controller.LoadGameBlock(nextGameBlock, startWindowFlag);
        else controller.LoadBlock(winBlock);
    }
    public void RestartLevel()
    {
        onScreenTimer.ResetTimer();
        quizController.RestartQuiz();
        StartGame();
    }
    public void StartGame()
    {
        overlay.SetActive(false);
        onScreenTimer.StartTimer();
        controller.HideActiveWindow();
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
        controller.OpenWindow(Windows.pauseWindow);
        onScreenTimer.StopTimer();
        animationController.OnPause();
        quizController.gameObject.SetActive(false);
        quizContainer.SetActive(false);
    }
    public void UnpauseGame()
    {
        quizController.gameObject.SetActive(true);
        controller.HideActiveWindow();
        onScreenTimer.StartTimer();
        quizContainer.SetActive(true);
        animationController.OnUnpause();
    }
    public void StopGame()
    {
        controller.HideActiveWindow();
        onScreenTimer.ResetTimer();
        quizContainer.SetActive(false);
        quizController.gameObject.SetActive(false);
        quizController.OnWin();
        animationController.OnSetup(quizController.GetQuestionNumber());
    }
}