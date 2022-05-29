using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalStartGameButton : MyButton
{
    [SerializeField] GameObject realStartScreen;
    public override void OnClick()
    {
        realStartScreen.SetActive(true);
        gameObject.SetActive(false);
    }
}
