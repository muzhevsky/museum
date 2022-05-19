using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinBlock : Block
{
    [SerializeField] List<Timer> timers;
    [SerializeField] WinAnimationController animController;
    [SerializeField] EndGameWindow endGameWindow;
    float spentTime;
    public override void SetActive(bool flag)
    {
        endGameWindow.gameObject.SetActive(false);
        content.SetActive(flag);
        foreach(Timer item in timers)
        {
            spentTime += item.spentTime;
            Console.WriteLine(item.spentTime);
            item.ResetTimerFull();
        }
        endGameWindow.SetTimerValue(Math.Round(spentTime, 2));
        spentTime = 0;
        animController.OnSetup(0);
    }
    public void OnWin()
    {
        endGameWindow.gameObject.SetActive(true);
    }
    public void Setup(GameBlock block)
    {
        endGameWindow.Setup(block);
    }
}
