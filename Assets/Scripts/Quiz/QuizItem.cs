using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/QuizItem")]
public class QuizItem : ScriptableObject {
    [SerializeField] Question question;
    [SerializeField] AnswerList answerList;
    [SerializeField] int number;
    public Question GetQuestion()
    {
        return question;
    }

    public AnswerList GetAnswerList()
    {
        return answerList;
    }
    public int GetNumber()
    {
        return number;
    }
}
