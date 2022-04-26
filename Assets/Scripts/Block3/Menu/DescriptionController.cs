using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionController : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI text;
    public void SetContent(SwiperItemContent content, RectTransform caller)
    {
        image.sprite = content.GetColoredImage();
        text.text = content.GetDescription();
        image.GetComponent<RectTransform>().sizeDelta = new Vector2(caller.sizeDelta.x * 1.2f, caller.sizeDelta.y * 1.2f);
    }
}
