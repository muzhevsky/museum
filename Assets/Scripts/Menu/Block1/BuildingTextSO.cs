using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/BuildingText")]
public class BuildingTextSO : ScriptableObject
{
    [TextArea(100,100)]
    public string text;
}
