using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionController : Button
{
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI text;
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
