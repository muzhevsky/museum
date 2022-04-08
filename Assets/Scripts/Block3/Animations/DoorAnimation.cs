using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MyAnimation
{
    [SerializeField] Animator loseBg;
    public override void Lose()
    {
        loseBg.Play("lose");
        StartCoroutine(AnimateLose());
    }
    public override IEnumerator AnimateLose()
    {
        float length = loseBg.runtimeAnimatorController.animationClips[2].length;
        yield return new WaitForSeconds(length);
        animationController.OnLoseAnimationEnd();
    }
    public override void Setup()
    {
        loseBg.Play("idle");
    }
}
