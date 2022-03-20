using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonController : Button
{
    [SerializeField] protected Block nextBlock;
    [SerializeField] protected GlobalUIController uiController;
    public override void OnClick()
    {
        uiController.LoadBlock(nextBlock);
    }
}
