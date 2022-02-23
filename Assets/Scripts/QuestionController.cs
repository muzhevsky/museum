using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionController : MonoBehaviour
{

    [SerializeField] GameObject textQuestionPrefab;
    [SerializeField] GameObject imageQuestionPrefab;
    public void AddTextQuestion(string text)
    {
        GameObject newItem = Instantiate(textQuestionPrefab, transform);
        newItem.GetComponent<TextQuestionController>().SetContent(text);
    }

    public void AddImageQuestion(string text, Sprite sprite)
    {
        GameObject newItem = Instantiate(imageQuestionPrefab, transform);
        newItem.GetComponent<ImageQuestionController>().SetContent(text, sprite);
    }

    public void SetQuestionUI(Question question)
    {
        question.SendContent(this);
    }
}