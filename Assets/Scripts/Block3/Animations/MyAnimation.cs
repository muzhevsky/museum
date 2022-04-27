using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAnimation : MonoBehaviour
{
    [SerializeField] protected Vector3 startPosition;
    [SerializeField] protected Quaternion startRotation;
    [SerializeField] protected float scale;
    [SerializeField] protected AnimationController animationController;
    [SerializeField] protected Animator animator;
    [SerializeField] protected float length;
    private void Start()
    {
        startPosition = ((RectTransform)transform).localPosition;
        startRotation = transform.rotation;
    }
    public virtual void Lose()
    {
        StartCoroutine(AnimateLose());
    }
    public virtual void Win()
    {
        StartCoroutine(AnimateWin());
    }
    public virtual void Lose(int answerNumber)
    {
        print(answerNumber);
        StartCoroutine(AnimateLose());
    }
    public virtual void Win(int answerNumber)
    {
        print(answerNumber);
        StartCoroutine(AnimateWin());
    }
    public virtual IEnumerator AnimateLose()
    {
        animator.Play("lose");
        float length = animator.runtimeAnimatorController.animationClips[2].length;
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
        ((RectTransform)transform).localPosition = startPosition;
        transform.rotation = startRotation;
        animator.Play("idle");
    }
    public virtual void Setup(int questionNumber)
    {
        Setup();
    }
    public virtual void Pause()
    {
        animator.speed = 0;
    }
    public virtual void Unpause()
    {
        animator.speed = 1;
    }
}
