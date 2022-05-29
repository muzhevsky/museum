using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBackgroundAnimation : MyAnimation
{
    public override void Lose()
    {
        StartCoroutine(AnimateLose());
    }
    public virtual IEnumerator AnimateLose()
    {
        animator.Play("lose");
        yield return new WaitForSeconds(length/3);
        animationController.OnLoseAnimationEnd();
    }
}
