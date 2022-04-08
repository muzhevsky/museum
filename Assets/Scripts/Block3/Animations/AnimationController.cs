using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] List<MyAnimation> animators;
    [SerializeField] GameBlock gameBlock;
    [SerializeField] GameObject overlay;
    public void OnVictory()
    {
        overlay.active = true;
        foreach (MyAnimation anim in animators)
        {
            anim.Win();
        }
    }
    public void OnDefeat()
    {
        overlay.active = true;
        foreach (MyAnimation anim in animators)
        {
            anim.Lose();
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
        overlay.active = false;
        gameBlock.Lose();
    }
    public void OnWinAnimationEnd()
    {
        overlay.active = false;
        gameBlock.Win();
    }
}
