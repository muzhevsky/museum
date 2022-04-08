using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButton : MenuButtonController
{
    [SerializeField] GameBlock block;

    public override void OnClick()
    {
        block.StopGame();
        uiController.LoadBlock(nextBlock);
    }
}
