using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameButton : Button
{
    [SerializeField] GameBlock gameBlock;
    public override void OnClick()
    {
        gameBlock.StartGame();
    }
}
