using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageQuestionController : MonoBehaviour
{

    [SerializeField] Image image;
    [SerializeField] Text text;

    public void SetContent(string text, Sprite sprite)
    {
        image.sprite = sprite;
        this.text.text = text;
    }

}
