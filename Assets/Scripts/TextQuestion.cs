using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/TextQuestion")]
public class TextQuestion : Question
{
    [SerializeField] string text;
    public override void SendContent(QuestionController visitor)
    {
        visitor.AddTextQuestion(text);
    }
}