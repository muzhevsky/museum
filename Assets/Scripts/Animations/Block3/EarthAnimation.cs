using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class EarthAnimation : MyAnimation
{
    [SerializeField] WinAnimationController controller;
    public override void Setup()
    {
        animator.Play("idle");
        if (gameObject.activeInHierarchy)StartCoroutine(AnimateIdle());
    }
    IEnumerator AnimateIdle()
    {
        yield return new WaitForSeconds(length);
        controller.OnWinAnimationEnd();
    }
}
