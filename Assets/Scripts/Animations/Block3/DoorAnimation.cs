using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class DoorAnimation : MyAnimation
{
    [SerializeField] Animator loseBg;
    public override void Lose()
    {
        loseBg.Play("lose");
        StartCoroutine(AnimateLose());
    }
    public override void Lose(int answerNumber)
    {
        loseBg.Play("lose");
        StartCoroutine(AnimateLose());
    }
    public override IEnumerator AnimateLose()
    {
        yield return new WaitForSeconds(length);
        animationController.OnLoseAnimationEnd();
    }
    public override void Setup()
    {
        base.Setup();
        loseBg.Play("idle", -1, 0);
    }
}
