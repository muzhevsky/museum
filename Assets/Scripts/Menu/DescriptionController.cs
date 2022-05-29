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
    [SerializeField] protected SwiperItemContent content;
    protected int pos = 0;
    public void SetContent(SwiperItemContent content)
    {
        this.content = content;
    }
    public virtual void LoadContent(RectTransform rTransform)
    {
        image.sprite = content.GetColoredImage(pos);
        text.text = content.GetDescription();
        image.GetComponent<RectTransform>().sizeDelta = new Vector2(rTransform.sizeDelta.x * scale, rTransform.sizeDelta.y * scale);
        scrollBarDescription.value = 0;
        contentDescription.offsetMax = new Vector2(contentDescription.offsetMin.x, 0);
    }
    public void SetNextImage(RectTransform rTransform)
    {
        if (pos < content.images.Length - 1) pos++;
        else pos = 0;
        LoadContent(rTransform);
    }
    public void SetPrevImage(RectTransform rTransform)
    {
        if (pos > 0) pos--;
        else pos = content.images.Length - 1;
        LoadContent(rTransform);
    }
}
