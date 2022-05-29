using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class StartGameButton : MyButton
{
    [SerializeField] GameBlock gameBlock;
    [SerializeField] GlobalUIController controller;
    [SerializeField] WinBlock endGameBlock;
    [SerializeField] Block beforeGameStartsBlock;
    public override void OnClick()
    {
        controller.LoadGameBlock(gameBlock,true);
        endGameBlock.Setup(gameBlock);
    }
}
