using UnityEngine;

public interface IQuestionVisitor
{
    GameObject AddQuestion(TextQuestion textQuestion);
    GameObject AddQuestion(ImageQuestion imageQuestion);
}
