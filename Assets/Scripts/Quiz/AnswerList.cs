using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/AnswerList")]
public class AnswerList: ScriptableObject
{
    [SerializeField] List<Answer> list;

    public void SetAnswers(AnswerListController answerListController)
    {
        foreach (Answer item in list)
        {
           item.SetContent(answerListController);
        }
    }
}