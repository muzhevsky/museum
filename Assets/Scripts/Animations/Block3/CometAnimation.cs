using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class CometAnimation : MyAnimation
{
    [SerializeField] RectTransform rightPoint;
    [SerializeField] RectTransform leftPoint;
    [SerializeField] GameObject crack;
    [SerializeField] Timer timer;
    [SerializeField] float questionNumber;
    public override void Lose()
    {
        StartCoroutine(AnimateLose());
    }
    public override void Win()
    {
        StartCoroutine(AnimateWin());
    }
    public override IEnumerator AnimateWin()
    {
        animator.speed = timer.timeLeft / length;
        if (animator.speed > 3) animator.speed = 3;
        if (animator.speed < 2) animator.speed = 2;
        if (questionNumber % 2 == 1) animator.SetBool("WinRight", true);
        else animator.SetBool("WinLeft", true);
        yield return new WaitForSeconds(length);
        animationController.OnWinAnimationEnd();
    }
    public override IEnumerator AnimateLose()
    {
        animator.speed *= timer.timeLeft / length;
        yield return new WaitForSeconds(length);
        crack.SetActive(true);
        yield return new WaitForSeconds(2);
        animationController.OnLoseAnimationEnd();
    }
    public override void Setup(int questionNumber)
    {
        animator.speed = 1;
        crack.SetActive(false);
        animator.SetBool("WinRight",false);
        animator.SetBool("WinLeft", false);
        this.questionNumber = questionNumber;
        SetIdleState(0);
    }
    public override void Unpause()
    {
        animator.speed = 1;
        SetIdleState(state);
    }
    void SetIdleState(float time)
    {
        if (questionNumber % 2 == 0)
        {
            transform.position = rightPoint.position;
            animator.Play("idleRight", 0, time);
        }
        else
        {
            transform.position = leftPoint.position;
            animator.Play("idleLeft", 0, time);
        }
    }
}
