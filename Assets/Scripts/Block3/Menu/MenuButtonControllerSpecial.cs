using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonControllerSpecial : MenuButtonController
{
    [SerializeField] GameObject DescriptionGO;
    [SerializeField] ScrollReseter scrollReseter;
    public override void OnClick()
    {
        DescriptionGO.SetActive(false);
        scrollReseter.Reset();
        uiController.LoadBlock(nextBlock);
    }
}
