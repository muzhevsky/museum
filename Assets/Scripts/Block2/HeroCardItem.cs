using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCardItem : Button
{
    [SerializeField] HeroItemContent content;
    [SerializeField] HeroDescriptionController descriptionController;
    public override void OnClick()
    {
        descriptionController.SetContent(content, (RectTransform)transform);
    }
}
