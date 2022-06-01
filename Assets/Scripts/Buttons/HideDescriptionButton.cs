using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideDescriptionButton : MyButton
{
    [SerializeField] GameObject DescriptionBlock;
    [SerializeField] RectTransform content;
    public override void OnClick()
    {
        DescriptionBlock.SetActive(false);
        content.anchoredPosition = new Vector2(0,0);
    }
}
