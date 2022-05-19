using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevelButton : GameButton
{
    public override void OnClick()
    {
        gameBlock.StartGame();
    }
}
