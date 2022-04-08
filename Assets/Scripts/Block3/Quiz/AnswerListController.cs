using System;
using System.Collections.Generic;
using UnityEngine;
public class AnswerListController : MonoBehaviour
{
    public GameObject textAnswer;
    public GameObject imageAnswer;
    List<SingleAnswerController> answerList = new List<SingleAnswerController>();
    QuizController quizController;
    GameObject newItem;

    public void AddTextAnswer(string text, Answer answer)
    {
        newItem = Instantiate(textAnswer, transform);
        TextAnswerController answerController = newItem.GetComponent<TextAnswerController>();
        answerList.Add(answerController);
        answerController.SetText(text);
        answerController.SetAnswer(answer);
        answerController.SetList(this);
    }

    internal void SetQuizController(QuizController quizController)
    {
        this.quizController = quizController;
    }

    public void AddImageAnswer(Sprite image, Answer answer)
    {
        newItem = Instantiate(imageAnswer, transform);
        ImageAnswerController answerController = newItem.GetComponent<ImageAnswerController>();
        answerList.Add(answerController);
        answerController.SetImage(image);
        answerController.SetAnswer(answer);
        answerController.SetList(this);
    }
    void ClearAnswersList()
    {
        if (answerList.Count > 0)
        {
            foreach (SingleAnswerController answer in answerList)
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
    public bool CheckCorrectAnswers()
    {
        bool res = true;
        foreach (SingleAnswerController item in answerList) { 
            print(item.IsRight());
            if (!item.IsRight()) res = false;
        } 
        return res;
    }
}