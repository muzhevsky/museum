using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class RestartButton : GameButton
{
    public override void OnClick()
    {
        gameBlock.RestartLevel();
    }
}
