using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButton : MyButton
{
    [SerializeField] protected GameBlock gameBlock;

    public void SetGameBlock(GameBlock block)
    {
        gameBlock = block;
    }
}
