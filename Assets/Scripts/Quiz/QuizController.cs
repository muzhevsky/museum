using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizController : MonoBehaviour
{
    [SerializeField] QuestionController questionController;
    [SerializeField] AnswerListController answerListController;
    [SerializeField] List<QuizItem> quizItems;
    [SerializeField] GameBlock gameBlock;
    int number = 0;
    public void StartQuiz()
    {
        if (number<quizItems.Count)
        {
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

    public void RestartQuiz()
    {
        number = 0;
        StartQuiz();
    }
}
