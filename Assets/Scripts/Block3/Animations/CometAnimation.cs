using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometAnimation : MyAnimation
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
        if (questionNumber % 2 == 0) animator.SetBool("WinRight", true);
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
        print(questionNumber);
        if (questionNumber%2==1) {
            transform.position = rightPoint.position;
            animator.Play("idleRight",-1,0);
        }
        else {
            transform.position = leftPoint.position;
            animator.Play("idleLeft",-1,0);
        }
            transform.rotation = startRotation;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
