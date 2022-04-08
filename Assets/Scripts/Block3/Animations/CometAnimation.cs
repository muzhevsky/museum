using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometAnimation : MyAnimation
{
    [SerializeField] RectTransform rightPoint;
    [SerializeField] RectTransform leftPoint;
    float questionNumber;
    public override void Lose()
    {
        //StartCoroutine(AnimateLose());
        animationController.OnLoseAnimationEnd();
    }
    public override void Win()
    {
        if (questionNumber % 2 == 0) animator.SetBool("WinRight",true);
        else animator.SetBool("WinLeft",true);
        StartCoroutine(AnimateWin());
    }
    public override IEnumerator AnimateWin()
    {
        yield return new WaitForSeconds(length);
        animationController.OnWinAnimationEnd();
    }
    public override IEnumerator AnimateLose()
    {
        yield return new WaitForSeconds(length);
        animationController.OnLoseAnimationEnd();
    }
    public override void Setup(int questionNumber)
    {
        animator.SetBool("WinRight",false);
        animator.SetBool("WinLeft", false);
        this.questionNumber = questionNumber;
        if (this.questionNumber%2==1) {
            transform.position = rightPoint.position;
            animator.Play("idleRight");
        }
        else {
            transform.position = leftPoint.position;
            animator.Play("idleLeft");
        }
            transform.rotation = startRotation;
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
