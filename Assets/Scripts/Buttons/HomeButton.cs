using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButton : GameButton
{
    [SerializeField] Block menuBlock;
    [SerializeField] GlobalUIController blockLoader;
    public override void OnClick()
    {
        gameBlock.StopGame();
        blockLoader.LoadBlock(menuBlock);
    }
}
