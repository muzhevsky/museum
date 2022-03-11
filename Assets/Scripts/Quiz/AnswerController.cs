using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
public class AnswerController : MonoBehaviour, IPointerDownHandler
{
    Answer answer;
    [SerializeField] Image image;
    [SerializeField] bool IsSelected = false;
    [SerializeField] bool IsInteractable = true;
    public void SetAnswer(Answer answer)
    {
        this.answer = answer;
    }
    public void SetWrongState()
    {
        image.DOColor(Color.red,0.5f);
    }
    public void SetRightState()
    {
        image.DOColor(Color.green, 0.5f);
    }
    public void SetDefaultState()
    {
        image.DOColor(Color.white, 0.5f);
        IsSelected = false;
    }
    public void SetSelectedState()
    {
        image.DOColor(Color.grey, 0.5f);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (IsInteractable)
        {
            IsSelected = !IsSelected;
            if (IsSelected) SetSelectedState();
            else SetDefaultState();
        }
    }
    public bool IsRight()
    {
        if (IsSelected == answer.IsRight)
        {
            if (answer.IsRight)
            {
                SetRightState();
            }
            return true;
        }
        else if(IsSelected && !answer.IsRight)
        {
            SetWrongState();
        }
        return false;
    }
}
