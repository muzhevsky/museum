using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObject/ImageQuestion")]
public class ImageQuestion : Question
{
    [SerializeField] string text;
    [SerializeField] Sprite sprite;

     public override void SendContent(QuestionController questionController)
    {
        questionController.AddImageQuestion(text, sprite);
    }
}