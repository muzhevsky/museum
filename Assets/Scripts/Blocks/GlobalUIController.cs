using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GlobalUIController : MonoBehaviour
{
    [SerializeField] Block menuBlock;
    [SerializeField] Block activeBlock;
    [SerializeField] Window activeWindow;
    [SerializeField] Window winWindow;
    [SerializeField] Window pauseWindow;
    [SerializeField] Window loseWindow;
    [SerializeField] Window startWindow;
    [SerializeField] Window endGameWindow;
    public void LoadBlock(Block block)
    {
        block.SetActive(true);
        activeBlock.SetActive(false);
        activeBlock = block;
    }
    public void LoadGameBlock(GameBlock block)
    {
        LoadBlock(block);
        startWindow.Setup(block);
        winWindow.Setup(block);
        loseWindow.Setup(block);
        pauseWindow.Setup(block);
        activeBlock = block;
        OpenWindow(Windows.startWindow);
    }
    public void HideActiveWindow()
    {
        activeWindow?.gameObject.SetActive(false);
    }
    public void OpenWindow(Windows window)
    {
        HideActiveWindow();
        switch (window)
        {
            case Windows.winWindow:
                winWindow.gameObject.SetActive(true);
                activeWindow = winWindow;
                break;

            case Windows.loseWindow:
                loseWindow.gameObject.SetActive(true);
                activeWindow = loseWindow;
                break;
            case Windows.pauseWindow:
                pauseWindow.gameObject.SetActive(true);
                activeWindow = pauseWindow;
                break;
            case Windows.startWindow:
                startWindow.gameObject.SetActive(true);
                activeWindow = startWindow;
                break;
        }
    }
}

public enum Windows
{
    winWindow,
    pauseWindow,
    loseWindow,
    startWindow,
    activeWindow,
    endGameWindow
}