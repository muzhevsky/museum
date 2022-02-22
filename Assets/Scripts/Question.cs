using UnityEngine;


public abstract class Question : ScriptableObject
{
    public virtual void AcceptVisitor(QuestionController visitor)
    {
        
    }
}