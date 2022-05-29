using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class RuleAnimation : MyAnimation
{
    float questionNumber;
    public override void Setup(int questionNumber)
    {
        animator.speed = 1;
        this.questionNumber = questionNumber;
        animator.Play("idle");
    }
    public override void Lose()
    {

    }
    public override void Win()
    {
        if (questionNumber % 2 == 0) animator.Play("rightTurn");
        else
        {
            animator.speed = 1;
            animator.Play("leftTurn");
        }
    }
}
