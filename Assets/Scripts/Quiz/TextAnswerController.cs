using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextAnswerController : AnswerController
{
    [SerializeField] TextMeshProUGUI text;
    public void SetText(string text)
    {
        this.text.SetText(text);
    }
}
