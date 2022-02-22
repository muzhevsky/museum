using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObject/ImageQuestion")]
public class ImageQuestion : Question
{
    [SerializeField] string text;
    [SerializeField] Sprite sprite;

     public override void AcceptVisitor(QuestionController visitor)
    {
        visitor.AddImageQuestion(text, sprite);
    }
}