using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/WindowInfo")]
public class WindowInfo : ScriptableObject
{
    public string endGameTitle;
    public string endGameDescription;
    public string startGameTarget;
    public string startGameTask;
    public string startGameDescription;
    public string loseTitle;
    public string loseDescription;
}
