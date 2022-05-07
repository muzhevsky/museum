using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleAnimation : MyAnimation
{
    float questionNumber;
    public override void Lose(int answerNumber)
    {

    }
    public override void Win(int answerNumber)
    {
        print(questionNumber);
        if (questionNumber % 2 == 0) animator.Play("leftTurn");
        else animator.Play("rightTurn");
    }
    public override void Setup(int questionNumber)
    {
        this.questionNumber = questionNumber;
        animator.Play("idle");
    }
}
