using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseWindow : Window
{
    [SerializeField] RestartButton restartButton;
    [SerializeField] HomeButton homeButton;
    [SerializeField] Text titleText;
    [SerializeField] Text descriptionText;
    public override void Setup(GameBlock block)
    {
        WindowInfo windowInfo = block.GetWindowInfo();
        gameBlock = block;
        restartButton.SetGameBlock(block);
        homeButton.SetGameBlock(block);
        titleText.text = windowInfo.loseTitle;
        descriptionText.text = windowInfo.loseDescription;
    }
}
