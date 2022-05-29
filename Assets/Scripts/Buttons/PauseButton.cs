using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PauseButton : MyButton   
{
    [SerializeField] GameBlock block;

    public override void OnClick()
    {
        block.PauseGame();
    }
}
