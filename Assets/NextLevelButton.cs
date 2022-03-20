using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelButton : Button
{
    [SerializeField] GameBlock block;
    public override void OnClick()
    {
        block.OnNextQuestion();
    }
}
