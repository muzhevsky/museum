using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastWinBlock : Block
{
    [SerializeField] List<Timer> timers;
    [SerializeField] Text winText;
    [SerializeField] AnimationController animController;
    float spentTime;
    public override void SetActive(bool flag)
    {
        gObject.SetActive(flag);
        foreach(Timer item in timers)
        {
            spentTime += item.spentTime;
            Console.WriteLine(item.spentTime);
            item.ResetTimerFull();
        }
        winText.text += Math.Round(spentTime, 2).ToString()+"!";
    }
}
