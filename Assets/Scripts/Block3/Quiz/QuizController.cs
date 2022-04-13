using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizController : MonoBehaviour
{
    [SerializeField] QuestionController questionController;
    [SerializeField] AnswerListController answerListController;
    [SerializeField] List<QuizItem> quizItems;
    [SerializeField] GameBlock gameBlock;
    [SerializeField] Text questionNumberText;
    [SerializeField] int number = 0;
    public bool QuizIsOver()
    {
        if (number < quizItems.Count) return false;
        return true;
    }
    public void StartQuiz()
    {
        if (number<quizItems.Count)
        {
            questionNumberText.text = "[Вопрос "+quizItems[number].GetNumber()+"]";
            questionController.SetQuestionUI(quizItems[number].GetQuestion());
            answerListController.SetAnswerUI(quizItems[number++].GetAnswerList());
            answerListController.SetQuizController(this);
        }
        else gameBlock.LoadNextLevel();
    }
    public void OnRightAnswer()
    {
        gameBlock.OnRightAnswer();
    }
    public void OnFalseAnswer()
    {
        gameBlock.OnFalseAnswer();
    }

    public int GetNumber()
    {
        return number;
    }
    public void RestartQuiz()
    {
        number--;
    }
    public void OnWin()
    {
        number = 0;
    }
}
