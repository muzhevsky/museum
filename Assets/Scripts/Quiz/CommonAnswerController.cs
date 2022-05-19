using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class CommonAnswerController : TextAnswerController
{
    public override void OnClick()
    {
        answerListController.OnAnswer(IsRight());
    }
}
