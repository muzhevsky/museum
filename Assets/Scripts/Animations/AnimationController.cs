using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] protected List<MyAnimation> animators;
    [SerializeField] protected GameBlock gameBlock;
    public virtual void OnVictory()
    {
        foreach (MyAnimation anim in animators)
        {
            anim.Win();
        }
    }
    public virtual void OnDefeat()
    {
        foreach (MyAnimation anim in animators)
        {
            anim.Lose();
        }
    }
    public void OnVictory(int answerNumber)
    {
        foreach (MyAnimation anim in animators)
        {
            anim.Win(answerNumber);
        }
    }
    public virtual void OnDefeat(int answerNumber)
    {
        foreach (MyAnimation anim in animators)
        {
            anim.Lose(answerNumber);
        }
    }
    public void OnSetup(int questionNumber)
    {
        foreach (MyAnimation anim in animators)
        {
            anim.Setup(questionNumber);
        }
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
        gameBlock.Lose();
    }
    public virtual void OnWinAnimationEnd()
    {
        gameBlock.Win();
    }
}
