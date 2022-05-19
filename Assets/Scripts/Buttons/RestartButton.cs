using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : GameButton
{
    public override void OnClick()
    {
        gameBlock.RestartLevel();
    }
}
