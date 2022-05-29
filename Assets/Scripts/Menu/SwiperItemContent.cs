using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObject/SwiperItemContent")]
public sealed class SwiperItemContent : ScriptableObject
{
    [SerializeField] string description;
    public Sprite[] images;
    public Sprite[] coloredImages;

    public Sprite GetColoredImage(int pos)
    {
        if (coloredImages != null)
            if(coloredImages.Length > pos) 
                return coloredImages[pos];
        return images[pos];
    }
    public Sprite GetImage(int pos)
    {
        return images[pos];
    }
    public string GetDescription()
    {
        return description;
    }
}
