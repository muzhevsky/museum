using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : Button   
{
    [SerializeField] GameBlock block;

    public override void OnClick()
    {
        block.PauseGame();
    }
}
