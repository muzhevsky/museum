using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroDescriptionController : DescriptionController
{
    [SerializeField] Text nameText;
    [SerializeField] Text descriptionText;
    [SerializeField] GameObject activeCard;
    [SerializeField] Scrollbar scrollBarDescription;
    [SerializeField] RectTransform contentDescription;
    public void SetContent(HeroItemContent content, RectTransform caller)
    {
        print("aaa");
        activeCard.SetActive(true);
        activeCard = caller.gameObject;
        activeCard.SetActive(false);
        scrollBarDescription.value = 1;
        contentDescription.offsetMax = new Vector2(330, 0);
        nameText.text = content.GetName();
        descriptionText.text = content.GetDescription();
        image.sprite = content.GetImage();
    }
}
