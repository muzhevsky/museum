using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlane : MyAnimation
{
    [SerializeField] Transform topPoint;
    [SerializeField] Transform midPoint;
    [SerializeField] Transform botPoint;
    public override void Lose(int answerNumber)
    {
        switch (answerNumber)
        {
            case 0:
                animator.Play("loseTop");
                break;
            case 1:
                animator.Play("loseMid");
                break;
            case 2:
                animator.Play("loseBot");
                break;
        }
    }
    public override void Win(int answerNumber)
    {

    }
}
