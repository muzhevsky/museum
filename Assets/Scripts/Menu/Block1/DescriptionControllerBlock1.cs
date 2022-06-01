using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionControllerBlock1 : DescriptionController
{
    [SerializeField] GameObject leftArrow;
    [SerializeField] GameObject rightArrow;
    public override void LoadContent(RectTransform rectTransform)
    {
        if(pos < content.images.Length) image.sprite = content.GetColoredImage(pos);
        else image.sprite = content.GetColoredImage(0);
        image.transform.localScale = new Vector2(scale, scale);
        text.text = content.GetDescription();
        if (content.images.Length > 1)
        {
            leftArrow.SetActive(true);
            rightArrow.SetActive(true);
        }
        else
        {
            leftArrow.SetActive(false);
            rightArrow.SetActive(false);
        }
    }
    public void SetNextImage()
    {
        if (pos < content.images.Length - 1) pos++;
        else pos = 0;
        LoadContent(null);
    }
    public void SetPrevImage()
    {
        if (pos > 0) pos--;
        else pos = content.images.Length - 1;
        LoadContent(null);
    }
}
