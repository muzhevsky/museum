using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class WinAnimationController : AnimationController
{
    [SerializeField] LastWinBlock block;

    public override void OnWinAnimationEnd()
    {
        block.OnWin();
    }
}
