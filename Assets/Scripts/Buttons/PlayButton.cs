using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : LoadBlockButton
{
    [SerializeField] ScrollReseter scrollReseter;
    public override void OnClick()
    {
        scrollReseter.ResetDescription();
        uiController.LoadBlock(nextBlock);
    }
}
