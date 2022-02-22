using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionVisitor : MonoBehaviour,IQuestionVisitor
{
    [SerializeField] GameObject textQuestionPrefab;
    [SerializeField] GameObject imageQuestionPrefab;
    public GameObject AddQuestion(TextQuestion textQuestion)
    {
        return textQuestionPrefab;
    }

    public GameObject AddQuestion(ImageQuestion imageQuestion)
    {
        return imageQuestionPrefab;
    }
}
