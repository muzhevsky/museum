using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionController : MonoBehaviour
{
    [SerializeField] protected Image image;
    [SerializeField] protected TextMeshProUGUI text;
    [SerializeField] protected Scrollbar scrollBarDescription;
    [SerializeField] protected RectTransform contentDescription;
    [SerializeField] protected float scale = 1;
    public void SetContent(SwiperItemContent content, RectTransform rTransform)
    {
        image.sprite = content.GetColoredImage();
        text.text = content.GetDescription();
        image.GetComponent<RectTransform>().sizeDelta = new Vector2(rTransform.sizeDelta.x * scale, rTransform.sizeDelta.y*scale); ;
        scrollBarDescription.value = 0;
        contentDescription.offsetMax = new Vector2(contentDescription.offsetMin.x, 0);
    }
}
