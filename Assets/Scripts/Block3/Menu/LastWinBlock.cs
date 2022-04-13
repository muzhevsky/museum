using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastWinBlock : Block
{
    [SerializeField] List<Timer> timers;
    [SerializeField] Text winText;
    [SerializeField] WinAnimationController animController;
    [SerializeField] GameObject WinScreen;
    float spentTime;
    public override void SetActive(bool flag)
    {
        WinScreen.SetActive(false);
        gObject.SetActive(flag);
        foreach(Timer item in timers)
        {
            spentTime += item.spentTime;
            Console.WriteLine(item.spentTime);
            item.ResetTimerFull();
        }
        winText.text = "Благодаря знаниям, Вам не только удалось выжить, но и закончить испытание за "+Math.Round(spentTime, 2).ToString()+"с !";
        spentTime = 0;
        animController.OnSetup(0);
    }
    public void OnWin()
    {
        WinScreen.SetActive(true);
    }
}
