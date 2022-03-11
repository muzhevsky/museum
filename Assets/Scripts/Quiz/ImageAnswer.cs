using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/ImageAnswer")]
public class ImageAnswer : Answer
{
    [SerializeField] Sprite image;

    public override void SetContent(AnswerListController answerListController)
    {
        answerListController.AddImageAnswer(image, this);
    }
}
