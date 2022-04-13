using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScreenController : MonoBehaviour
{
    [SerializeField] CanvasGroup cGroup;
    public void Enable()
    {
        gameObject.SetActive(true);
        cGroup.DOFade(1f, 0.8f);
    }
    public void Disable()
    {
        cGroup.DOFade(0f,0.8f).OnComplete(()=>gameObject.SetActive(false));
    }
}
