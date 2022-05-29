using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SoundControl : MyButton
{
    [SerializeField] VideoPlayer player;
    [SerializeField] float value;
    bool isOn = true;
    public override void OnClick()
    {
        isOn = !isOn;
        if (isOn)
        {
            player.SetDirectAudioVolume(1, value);
            player.SetDirectAudioVolume(0, value);
        }
        else
        {
            player.SetDirectAudioVolume(1, 0);
            player.SetDirectAudioVolume(0, 0);
        }
    }
}
