using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionController : MonoBehaviour
{
    [SerializeField] Image questionImage;
    [SerializeField] Text questionText;
    [SerializeField] QuestionList questionList;

    private void Start()
    {
        IQuestion question = questionList.GetNewQuestion();
        switch (question.GetQuestionType())
        {
            case "text":
                questionImage.gameObject.SetActive(false);
                questionText.text = question.GetText();
                break;
            case "image":
                questionImage.gameObject.SetActive(true);
                questionText.text = question.GetText();
                break;
        }
    }
}
