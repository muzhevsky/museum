using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObject/SwiperItemContent")]
public sealed class SwiperItemContent : ScriptableObject
{
    [SerializeField] string description;
    [SerializeField] Sprite image;
    [SerializeField] Sprite coloredImage;
    public Sprite GetColoredImage()
    {
        return coloredImage;
    }
    public Sprite GetImage()
    {
        return image;
    }
    public string GetDescription()
    {
        return description;
    }
}
