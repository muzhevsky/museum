using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public sealed class Block2Swiper : MonoBehaviour
{
    [SerializeField] RectTransform Content;
    float startPositionX;
    int state = 0;
    bool interactable;
    private void Start()
    {
        interactable = true;
        state = 0;
    }
    private void Update()
    {
        if (interactable)
        {
            if (Input.GetMouseButtonDown(0)) startPositionX = Content.offsetMin.x;
            if (Input.GetMouseButtonUp(0))
            {
                if (Content.offsetMin.x - startPositionX < -200)
                {
                    if (state == 0) MoveToState(1);
                }
                else if (Content.offsetMin.x - startPositionX > 200)
                {
                    if (state == 1) MoveToState(0);
                }
                else
                {
                    interactable = false;
                    Content.DOLocalMoveX(startPositionX, 0.3f).OnComplete(() => { interactable = true; });
                }
            }
        }
    }
    public void MoveToState(int state)
    {
        this.state = state;
        interactable = false;
        Content.DOLocalMoveX(-state * 1920, 0.3f).OnComplete(() => { interactable = true; });
    }
}
