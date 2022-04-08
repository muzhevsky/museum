using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionController : Button
{
    [SerializeField] Image image;
    [SerializeField] Text text;
    public override void OnClick()
    {
        gameObject.SetActive(false);
    }
    public void SetContent(SwiperItemContent content)
    {
        image.sprite = content.GetColoredImage();
        text.text = content.GetDescription();   
    }
}
