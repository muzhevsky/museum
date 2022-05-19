using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameButton : Button
{
    [SerializeField] GameBlock gameBlock;
    [SerializeField] GlobalUIController controller;
    [SerializeField] WinBlock endGameBlock;
    [SerializeField] Block beforeGameStartsBlock;
    public override void OnClick()
    {
        controller.LoadGameBlock(gameBlock);
        endGameBlock.Setup(gameBlock);
    }
}
