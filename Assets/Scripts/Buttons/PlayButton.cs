using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : LoadBlockButton
{
    public override void OnClick()
    {
        uiController.LoadBlock(nextBlock);
    }
}
