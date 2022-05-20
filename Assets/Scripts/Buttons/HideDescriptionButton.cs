using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideDescriptionButton : Button
{
    [SerializeField] GameObject DescriptionBlock;
    public override void OnClick()
    {
        DescriptionBlock.SetActive(false);
    }
}
