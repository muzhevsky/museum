using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class SoundControl : MyButton
{
    [SerializeField] VideoPlayer player;
    [SerializeField] float value;
    [SerializeField] Sprite onSprite;
    [SerializeField] Sprite offSprite;
    [SerializeField] Image image;
    bool isOn = true;
    public override void OnClick()
    {
        isOn = !isOn;
        if (isOn)
        {
            player.SetDirectAudioVolume(1, value);
            player.SetDirectAudioVolume(0, value);
            image.sprite = onSprite;
        }
        else
        {
            player.SetDirectAudioVolume(1, 0);
            player.SetDirectAudioVolume(0, 0);
            image.sprite = offSprite;
        }
    }
}
