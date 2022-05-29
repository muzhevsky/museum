using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBlock1BackgroundAnimation : MyAnimation
{
    public override void Setup()
    {
        if(gameObject.activeInHierarchy) StartCoroutine(AnimateWin());
    }
}
