using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/AnswerList")]
public class AnswerList: ScriptableObject
{
    [SerializeField] List<Answer> list;
}