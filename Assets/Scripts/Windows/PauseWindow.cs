using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseWindow : Window
{
    [SerializeField] UnpauseButton unpauseButton;
    [SerializeField] RestartButton restartButton;
    [SerializeField] HomeButton homeButton;
    public override void Setup(GameBlock block)
    {
        gameBlock = block;
        unpauseButton.SetGameBlock(block);
        restartButton.SetGameBlock(block);
        homeButton.SetGameBlock(block);
    }
}
