using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/HeroItemContent")]
public class HeroItemContent : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] string description;
    [SerializeField] Sprite image;
    public string GetName()
    {
        return name;
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
