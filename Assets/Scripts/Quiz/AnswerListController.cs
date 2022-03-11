using System.Collections.Generic;
using UnityEngine;
public class AnswerListController : MonoBehaviour
{
    public GameObject textAnswer;
    public GameObject imageAnswer;
    List<AnswerController> answerList = new List<AnswerController>();
    GameObject newItem;

    public void AddTextAnswer(string text, Answer answer)
    {
        newItem = Instantiate(textAnswer, transform);
        TextAnswerController answerController = newItem.GetComponent<TextAnswerController>();
        answerList.Add(answerController);
        answerController.SetText(text);
        answerController.SetAnswer(answer);
    }
    public void AddImageAnswer(Sprite image, Answer answer)
    {
        newItem = Instantiate(imageAnswer, transform);
        ImageAnswerController answerController = newItem.GetComponent<ImageAnswerController>();
        answerList.Add(answerController);
        answerController.SetImage(image);
        answerController.SetAnswer(answer);
    }
    void ClearAnswersList()
    {
        if (answerList.Count > 0)
        {
            foreach (AnswerController answer in answerList)
                Destroy(answer.gameObject);
            answerList.Clear();
        }
    }
    public void SetAnswerUI(AnswerList answerList)
    {
        ClearAnswersList();
        answerList.SetAnswers(this);
    }

    void ChangeStates()
    {
        foreach(AnswerController item in answerList)
        {
            item.SetDefaultState();
        }
    }

    public bool CheckCorrectAnswers()
    {
        bool res = true;
        foreach (AnswerController item in answerList) { 
            print(item.IsRight());
            if (!item.IsRight()) res = false;
        }
        if(!res) ChangeStates();
        return res;
    }
}