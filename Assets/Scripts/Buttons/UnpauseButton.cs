using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseButton : GameButton
{
    public override void OnClick()
    {
        gameBlock.UnpauseGame();
    }
}
