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
        if (answerListController.CheckCorrectAnswers())
        {
            // сюда можно анимацию вставить
            StartCoroutine(SetUI());
        }
    }
    public IEnumerator SetUI()
    {
        yield return new WaitForSeconds(1);
        if (number<list.Count)
        {
            questionController.SetQuestionUI(list[number].GetQuestion());
            answerListController.SetAnswerUI(list[number++].GetAnswerList());
        }
        else EndQuiz();
    }
    void EndQuiz()
    {

    }
}
