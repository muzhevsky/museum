using System;
using System.Collections.Generic;
using UnityEngine;
public sealed class AnswerListController : MonoBehaviour
{
    public GameObject textAnswer;
    List<TextAnswerController> answerList = new List<TextAnswerController>();
    QuizController quizController;
    GameObject newItem;
    int number;
    private void Start()
    {
        number = 0;
    }
    public void AddTextAnswer(string text, Answer answer)
    {
        newItem = Instantiate(textAnswer, transform);
        TextAnswerController answerController = newItem.GetComponent<TextAnswerController>();
        answerList.Add(answerController);
        answerController.SetText(text);
        answerController.SetAnswer(answer);
        answerController.SetList(this);
        answerController.SetNumber(number++);
    }

    internal void SetQuizController(QuizController quizController)
    {
        this.quizController = quizController;
    }
    void ClearAnswersList()
    {
        number = 0;
        if (answerList.Count > 0)
        {
            foreach (TextAnswerController answer in answerList)
                Destroy(answer.gameObject);
            answerList.Clear();
        }
    }
    public void SetAnswerUI(AnswerList answerList)
    {
        ClearAnswersList();
        answerList.SetAnswers(this);
    }
    public void OnAnswer(bool isRight)
    {
        if (isRight) quizController.OnRightAnswer();
        else quizController.OnFalseAnswer();
    }
    public void OnAnswer(bool isRight, int answerNumber)
    {
        if (isRight) quizController.OnRightAnswer(answerNumber);
        else quizController.OnFalseAnswer(answerNumber);
        number = 0;
    }
    public bool CheckCorrectAnswers()
    {
        bool res = true;
        foreach (CommonAnswerController item in answerList) { 
            print(item.IsRight());
            if (!item.IsRight()) res = false;
        } 
        return res;
    }
}