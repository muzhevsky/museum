using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "ScriptableObject/QuestionList")]
public class QuestionList : ScriptableObject
{
    [ContextMenuItem("ClearQuestionList", "ClearQuestionList")]
    [SerializeField] List<IQuestion> questions = new List<IQuestion>();
    int current = 0;
    public IQuestion GetNewQuestion()
    {
        return questions[current++];
    }
    public void ClearQuestionList()
    {
        questions.Clear();
    }
}
