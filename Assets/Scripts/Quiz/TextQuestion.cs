using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/TextQuestion")]
public class TextQuestion : Question
{
    [SerializeField] string text;
    public override void SendContent(QuestionController questionController)
    {
        questionController.AddTextQuestion(text);
    }
}