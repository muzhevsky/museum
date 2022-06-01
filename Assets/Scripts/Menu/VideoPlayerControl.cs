using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using DG.Tweening;
public class VideoPlayerControl : MyButton
{
    [SerializeField] Text restartPromptText;
    VideoPlayer player;

    private void Start()
    {
        player = GetComponent<VideoPlayer>();
        player.loopPointReached += OnMovieFinished;
    }

    public override void OnClick()
    {
        if(player.frame > player.frameCount-2*player.frameRate)
        {
            player.frame = 0;
            player.Play();
            restartPromptText.gameObject.SetActive(false);
            restartPromptText.GetComponent<CanvasGroup>().alpha = 0;
        }
    }

    void OnMovieFinished(UnityEngine.Video.VideoPlayer player)
    {
        restartPromptText.gameObject.SetActive(true);
        restartPromptText.gameObject.GetComponent<CanvasGroup>().DOFade(1,2f);
    }
}
