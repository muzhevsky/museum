using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerController : Button
{

    protected Answer answer;
    [SerializeField] protected int number;
    [SerializeField] protected AnswerListController answerListController;
    public bool IsRight()
    {
        if (answer.IsRight) return true;
        return false;
    }
    public void SetAnswer(Answer answer)
    {
        this.answer = answer;
    }
    public void SetList(AnswerListController list)
    {
        answerListController = list;
    }
    public void SetNumber(int number)
    {
        this.number = number;
    }
}
