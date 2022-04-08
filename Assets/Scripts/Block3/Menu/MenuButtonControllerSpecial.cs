using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonControllerSpecial : MenuButtonController
{
    [SerializeField] GameObject DescriptionGO;
    public override void OnClick()
    {
        DescriptionGO.SetActive(false);
        uiController.LoadBlock(nextBlock);
    }
}
