using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class LampAnimation : MyAnimation
{
    [SerializeField] LampAnimation green;
    [SerializeField] LampAnimation red;
    [SerializeField] float duration;
    public override void Win()
    {
        green.gameObject.SetActive(true);
        green.FadeIn();
    }
    public override void Lose()
    {
        red.gameObject.SetActive(true);
        red.FadeIn();
    }
    public override void Lose(int answerNumber)
    {
        Lose();
    }
    public override void Win(int answerNumber)
    {
        Win();
    }
    public void FadeIn()
    {
        GetComponent<Image>().DOFade(1, 0.5f).OnComplete(()=> GetComponent<Image>().DOFade(0, 0.5f).OnComplete(() => GetComponent<Image>().DOFade(1, 0.5f).OnComplete(() => GetComponent<Image>().DOFade(0, 0.5f).OnComplete(()=>gameObject.SetActive(false)))));
    }
    public override void Setup()
    {
    }
}
