using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] protected List<MyAnimation> animators;
    [SerializeField] protected GameBlock gameBlock;
    [SerializeField] protected GameObject overlay;
    public void OnVictory()
    {
        overlay.active = true;
        foreach (MyAnimation anim in animators)
        {
            anim.Win();
        }
    }
    public virtual void OnDefeat()
    {
        overlay.active = true;
        foreach (MyAnimation anim in animators)
        {
            anim.Lose();
        }
    }
    public void OnVictory(int answerNumber)
    {
        overlay.active = true;
        foreach (MyAnimation anim in animators)
        {
            anim.Win(answerNumber);
        }
    }
    public virtual void OnDefeat(int answerNumber)
    {
        overlay.active = true;
        foreach (MyAnimation anim in animators)
        {
            anim.Lose(answerNumber);
        }
    }
    public void OnSetup(int questionNumber)
    {
        overlay.active = false;
        foreach (MyAnimation anim in animators)
        {
            anim.Setup(questionNumber);
        }
        OnUnpause();
    }
    public void OnPause()
    {
        foreach (MyAnimation anim in animators)
        {
            anim.Pause();
        }
    }
    public void OnUnpause()
    {
        foreach (MyAnimation anim in animators)
        {
            anim.Unpause();
        }
    }
    public void OnLoseAnimationEnd()
    {
        overlay.SetActive(false);
        gameBlock.Lose();
    }
    public virtual void OnWinAnimationEnd()
    {
        overlay.SetActive(false);
        gameBlock.Win();
    }
}
