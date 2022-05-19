using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelButton : GameButton
{
    public override void OnClick()
    {
        gameBlock.OnNextQuestion();
    }
}
