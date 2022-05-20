using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class StartWindow : Window
{
    [SerializeField] StartLevelButton startGameButton;
    [SerializeField] Text targetText;
    [SerializeField] Text taskText;
    [SerializeField] Text descriptionText;
    public override void Setup(GameBlock block)
    {
        WindowInfo windowInfo = block.GetWindowInfo();
        gameBlock = block;
        startGameButton.SetGameBlock(block);
        targetText.text = windowInfo.startGameTarget;
        taskText.text = windowInfo.startGameTask;
        descriptionText.text = windowInfo.startGameDescription;
    }
}
