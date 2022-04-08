using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthAnimation : MyAnimation
{
    public override void Setup()
    {
        animator.Play("idle");
        StartCoroutine(AnimateIdle());
    }
    IEnumerator AnimateIdle()
    {
        yield return new WaitForSeconds(length);
    }
}
