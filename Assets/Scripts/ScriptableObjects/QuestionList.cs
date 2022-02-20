using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionList : ScriptableObject
{
    [SerializeField]List<IQuestion> questions = new List<IQuestion>();
}
