using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuestionController : MonoBehaviour
{
    [SerializeField] Text text;

    public void SetContent(string text)
    {
        this.text.text = "["+text+"]";
    }
}
