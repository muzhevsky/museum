using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCardItem : MyButton
{
    [SerializeField] HeroItemContent content;
    [SerializeField] HeroDescriptionController descriptionController;
    [SerializeField] NextHeroButton button;
    [SerializeField] int index;
    public override void OnClick()
    {
        SetContent();
        button?.SetActiveCard(this, index);
    }
    public void SetContent()
    {
        descriptionController.SetContent(content, (RectTransform)transform);
    }
}
