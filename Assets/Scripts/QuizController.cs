using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizController : MonoBehaviour
{
    [SerializeField] QuestionController questionController;
    [SerializeField] AnswerListController answerListController;
    [SerializeField] List<QuizItem> list;
    int number = 0;
    public void ContinueQuiz()
    {
        questionController.SetQuestionUI(list[number++].GetQuestion());
      //  answerListController.SetAnswerUI(list[number++].GetAnswerList());
    }
}
