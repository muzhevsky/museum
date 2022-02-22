using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/TextQuestion")]
public class TextQuestion : Question
{
    [SerializeField] string text;
    public override void AcceptVisitor(QuestionController visitor)
    {
        visitor.AddTextQuestion(text);
    }
}