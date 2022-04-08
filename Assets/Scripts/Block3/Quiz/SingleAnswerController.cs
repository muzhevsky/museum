using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
public class SingleAnswerController : AnswerController
{
    [SerializeField] Image image;
    public override void OnClick()
    {
        answerListController.OnAnswer(IsRight());
    }
}
