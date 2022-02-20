using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObject/TextQuestion")]
public class TextQuestion : ScriptableObject,IQuestion
{
    [SerializeField] string text = "";
    public const string type = "text";
    public string GetText()
    {
        return text;
    }
    public string GetQuestionType()
    {
        return type;
    }
}
