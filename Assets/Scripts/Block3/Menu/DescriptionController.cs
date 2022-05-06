using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DescriptionController : MonoBehaviour
{
    [SerializeField] protected Image image;
    [SerializeField] protected TextMeshProUGUI text;
    public void SetContent(SwiperItemContent content, RectTransform caller)
    {
        image.sprite = content.GetColoredImage();
        text.text = content.GetDescription();
        image.GetComponent<RectTransform>().sizeDelta = new Vector2(caller.sizeDelta.x, caller.sizeDelta.y);
    }
}
