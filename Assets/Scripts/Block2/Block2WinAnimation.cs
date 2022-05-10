using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block2WinAnimation : MyAnimation
{
    [SerializeField] WinAnimationController controller;
    public override void Setup()
    {
        animator.Play("idle");
        StartCoroutine(AnimateIdle());
    }
    IEnumerator AnimateIdle()
    {
        yield return new WaitForSeconds(length);
        controller.OnWinAnimationEnd();
    }
}
