using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionController : MonoBehaviour
{

    [SerializeField] GameObject textQuestionPrefab;
    [SerializeField] GameObject imageQuestionPrefab;
    GameObject newItem;
    public void AddTextQuestion(string text)
    {
        if (newItem != null) Destroy(newItem);
        newItem = Instantiate(textQuestionPrefab, transform);
        newItem.GetComponent<TextQuestionController>().SetContent(text);
    }

    public void SetQuestionUI(Question question)
    {
        question.SendContent(this);
    }
}