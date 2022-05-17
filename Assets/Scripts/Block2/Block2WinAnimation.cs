using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Block2WinAnimation : MyAnimation
{
    [SerializeField] WinAnimationController controller;
    public override void Setup()
    {
        if (gameObject.activeSelf)
        {
            animator.Play("idle");
            StartCoroutine(AnimateIdle());
        }
    }
    IEnumerator AnimateIdle()
    {
        yield return new WaitForSeconds(length);
        controller?.OnWinAnimationEnd();
    }
}
