using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAnswerController : SingleAnswerController
{
    [SerializeField] Image sprite;
    public void SetImage(Sprite image)
    {
        this.sprite.sprite = image;
    }
}