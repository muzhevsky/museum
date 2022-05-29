using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchLayoutButton : MyButton
{
    [SerializeField] GameObject layout;
    [SerializeField] Text buttonText; 
    bool isActive = true;
    public override void OnClick()
    {
        layout.SetActive(!isActive);
        isActive = !isActive;
        if (isActive) buttonText.text = "Закрыть список";
        else buttonText.text = "Открыть список";
    }
}
