using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/QuizItem")]
public class QuizItem : ScriptableObject {
    [SerializeField] Question question;
    [SerializeField] AnswerList answerList;
    public Question GetQuestion()
    {
        return question;
    }

    public AnswerList GetAnswerList()
    {
        return answerList;
    }
}
