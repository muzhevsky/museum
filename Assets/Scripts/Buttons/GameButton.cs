using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButton : Button
{
    [SerializeField] protected GameBlock gameBlock;

    public void SetGameBlock(GameBlock block)
    {
        gameBlock = block;
    }
}
