using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController2 : AnimationController
{
    public void OnDefeat(int answerNumber)
    {
        print("lose " + answerNumber.ToString());
        switch (answerNumber)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }
    public void OnVictory(int answerNumber)
    {
        print("win " + answerNumber.ToString());
        switch (answerNumber)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }
}
