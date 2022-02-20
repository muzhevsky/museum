using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObject/ImageQuestion")]
public class ImageQuestion : ScriptableObject, IQuestion
{
    [SerializeField] string text = "";
    [SerializeField] Image image;
    const string type = "image";
    public string GetText()
    {
        return text;
    }
    public string GetQuestionType()
    {
        return type;
    }
}
