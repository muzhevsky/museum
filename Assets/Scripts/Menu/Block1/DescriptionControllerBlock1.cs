using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescriptionControllerBlock1 : DescriptionController
{
    [SerializeField] GameObject leftArrow;
    [SerializeField] GameObject rightArrow;
    public override void LoadContent(RectTransform rectTransform)
    {
        image.sprite = content.GetColoredImage(pos);
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
        print("next");
        if (pos < content.images.Length - 1) pos++;
        else pos = 0;
        LoadContent(null);
    }
    public void SetPrevImage()
    {
        print("prev");
        if (pos > 0) pos--;
        else pos = content.images.Length - 1;
        LoadContent(null);
    }
}
