using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartEntireGameButton : Button
{
    [SerializeField] Block block;
    [SerializeField] GlobalUIController controller;
    public override void OnClick()
    {
        controller.LoadBlock(block);
    }

    public void SetBeforeGameStartsBlock(Block block)
    {
        this.block = block;
    }

    public void SetNextBlock(Block block)
    {
        this.block = block;
    }
}
