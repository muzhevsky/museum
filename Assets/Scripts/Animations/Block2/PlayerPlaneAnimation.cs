using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public sealed class PlayerPlaneAnimation : MyAnimation
{
    [SerializeField] ExplosionEffectGenerator generator;
    [SerializeField] CanvasGroup canvasGroup;
    public override void Win(int answerNumber)
    {
        switch (answerNumber)
        {
            case 0:
                animator.Play("winTop");
                break;
            case 1:
                animator.Play("winMid");
                break;
            case 2:
                animator.Play("winBot");
                break;
        }
        StartCoroutine(WaitForWin());
    }
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
        StartCoroutine(WaitForLose());
    }
    IEnumerator WaitForWin()
    {
        yield return new WaitForSeconds(length);
        animationController.OnWinAnimationEnd();
    }
    IEnumerator WaitForLose()
    {
        float time = length / 3;
        yield return new WaitForSeconds(time);
        generator.gameObject.SetActive(true);
        yield return new WaitForSeconds(time*2);
        canvasGroup.DOFade(0, length / 3).OnComplete(() => {
            generator.TurnOff();
            animationController.OnLoseAnimationEnd();
        });
    }
    public override void Setup()
    {
        base.Setup();
        canvasGroup.alpha = 1;
        generator.TurnOff();
    }
    public override void Unpause()
    {
        animator.speed = 1;
        animator.Play("trueIdle", 0, state);
    }
}
