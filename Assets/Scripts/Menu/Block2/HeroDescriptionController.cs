using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class HeroDescriptionController : DescriptionController
{
    [SerializeField] Text nameText;
    [SerializeField] Text descriptionText;
    [SerializeField] GameObject activeCard;
    public void SetContent(HeroItemContent content, RectTransform caller)
    {
        activeCard?.SetActive(true);
        activeCard = caller.gameObject;
        activeCard?.SetActive(false);
        scrollBarDescription.value = 0;
        contentDescription.offsetMax = new Vector2(330, 0);
        nameText.text = content.GetName();
        descriptionText.text = content.GetDescription();
        image.sprite = content.GetImage();
    }
}
