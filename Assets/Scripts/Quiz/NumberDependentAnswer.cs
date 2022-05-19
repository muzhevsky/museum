using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberDependentAnswer : TextAnswerController
{
    public override void OnClick()
    {
        answerListController.OnAnswer(IsRight(), number);
    }
}
