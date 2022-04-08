using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : Button
{
    [SerializeField] GameBlock block;
    public override void OnClick()
    {
        block.RestartGame();
    }
}
