using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAnimation : MonoBehaviour
{
    [SerializeField] protected AnimationController animationController;
    [SerializeField] protected Animator animator;

    [SerializeField] protected float length;
    [SerializeField] protected float state;
    public virtual void Lose(int answerNumber)
    {
        StartCoroutine(AnimateLose());
    }
    public virtual void Win(int answerNumber)
    {
        StartCoroutine(AnimateWin());
    }
    public virtual void Lose()
    {
        StartCoroutine(AnimateLose());
    }
    public virtual void Win()
    {
        StartCoroutine(AnimateWin());
    }
    public virtual IEnumerator AnimateLose()
    {
        animator.Play("lose");
        float length = animator.runtimeAnimatorController.animationClips[1].length;
        yield return new WaitForSeconds(length);
        animationController.OnLoseAnimationEnd();
    }
    public virtual IEnumerator AnimateWin()
    {
        animator.Play("win");
        float length = animator.runtimeAnimatorController.animationClips[1].length;
        yield return new WaitForSeconds(length);
        animationController.OnWinAnimationEnd();
    }
    public virtual void Setup()
    {
        animator.Play("idle");
        animator.speed = 1;
    }
    public virtual void Setup(int questionNumber)
    {
        Setup();
    }
    public virtual void Pause()
    {
        animator.speed = 0;
        state = animator.GetCurrentAnimatorStateInfo(0).normalizedTime % 1;
    }
    public virtual void Unpause()
    {
        animator.speed = 1;
        animator.Play("idle", 0, state);
    }
}
