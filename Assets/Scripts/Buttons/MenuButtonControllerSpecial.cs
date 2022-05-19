using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonControllerSpecial : LoadBlockButton
{
    [SerializeField] GameObject DescriptionGO;
    [SerializeField] ScrollReseter scrollReseter;
    public override void OnClick()
    {
        DescriptionGO.SetActive(false);
        scrollReseter?.OnReset();
        uiController.LoadBlock(nextBlock);
    }
}
