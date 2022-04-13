using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollReseter : MonoBehaviour
{
    [SerializeField] Scrollbar scrollBarDescription;
    [SerializeField] RectTransform contentDescription;
    [SerializeField] Scrollbar scrollBarSlider;
    [SerializeField] RectTransform sliderDescription;
    public void ResetDescription()
    {
        scrollBarDescription.value = 1;
        contentDescription.offsetMax = new Vector2(contentDescription.offsetMin.x, 0);
    }
    public void ResetSlider()
    {
        scrollBarSlider.value = 0;
        sliderDescription.offsetMin = new Vector2(0, sliderDescription.offsetMin.y);
    }
    public void Reset()
    {
        ResetSlider();
        ResetDescription();
    }
}
