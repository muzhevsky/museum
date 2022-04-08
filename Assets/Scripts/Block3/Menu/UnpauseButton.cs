using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnpauseButton : Button
{
    [SerializeField] GameBlock gameBlock;
    public override void OnClick()
    {
        gameBlock.UnpauseGame();
    }
}
