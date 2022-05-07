using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlayerPlaneAnimation : MyAnimation
{
    [SerializeField] ExplosionEffectGenerator generator;
    [SerializeField] CanvasGroup canvasGroup;
    public override void Win(int answerNumber)
    {
        print(answerNumber);
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
        print(answerNumber);
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
        yield return new WaitForSeconds(length/3);
        generator.gameObject.SetActive(true);
        yield return new WaitForSeconds(length*2/3);
        canvasGroup.DOFade(0, length / 3).OnComplete(() => {
            generator.TurnOff();
            animationController.OnLoseAnimationEnd();
        });
    }
    public override void Setup()
    {
        canvasGroup.alpha = 1;
        base.Setup();
        generator.TurnOff();
    }
}
