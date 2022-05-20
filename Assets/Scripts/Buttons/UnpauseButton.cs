using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class UnpauseButton : GameButton
{
    public override void OnClick()
    {
        gameBlock.UnpauseGame();
    }
}
