using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/TextAnswer")]
public class TextAnswer : Answer
{
    [SerializeField] string text;

    public override void SetContent(AnswerListController answerListController)
    {
        answerListController.AddTextAnswer(text, this);
    }
}
