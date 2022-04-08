using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleAnimation : MyAnimation
{
    float questionNumber;
    public override void Lose()
    {
        //StartCoroutine(AnimateLose());
        animationController.OnLoseAnimationEnd();
    }
    public override void Win()
    {
        if (questionNumber % 2 == 0) animator.Play("leftTurn");
        else animator.Play("rightTurn");
    }
    public override void Setup(int questionNumber)
    {
        this.questionNumber = questionNumber;
        animator.Play("idle");
    }
}
