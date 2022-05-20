using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class EndGameWindow : Window
{
    [SerializeField] RestartEntireGameButton restartGameButton;
    [SerializeField] LoadBlockButton homeButton;
    [SerializeField] Text titleText;
    [SerializeField] Text resultText;
    public override void Setup(GameBlock block)
    {
        WindowInfo windowInfo = block.GetWindowInfo();
        restartGameButton.SetNextBlock(block);
        titleText.text = windowInfo.endGameTitle;
        resultText.text = windowInfo.endGameDescription;
        restartGameButton.SetBeforeGameStartsBlock(block.GetBeforeGameStartsBlock());
    }
    public void SetTimerValue(double value)
    {
        resultText.text += " "+value.ToString()+"c";
    }
}
