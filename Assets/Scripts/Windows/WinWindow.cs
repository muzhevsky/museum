using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinWindow : Window
{
    [SerializeField] NextLevelButton nextLevelButton;
    [SerializeField] RestartButton restartButton;
    [SerializeField] HomeButton homeButton;
    public override void Setup(GameBlock block)
    {
        gameBlock = block;
        nextLevelButton.SetGameBlock(gameBlock);
        restartButton.SetGameBlock(gameBlock);
        homeButton.SetGameBlock(gameBlock);
    }
}
