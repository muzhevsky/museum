using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class HoseAnimation : MyAnimation
{
    public override void Lose()
    {
        animator.SetBool("lose", true);
        animator.SetBool("win", true);
    }
    public override void Setup()
    {
        animator.Play("idle", -1, 0);
        animator.SetBool("lose", false);
        animator.SetBool("win", false);
    }
}
