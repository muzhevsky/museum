using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Block2Swiper : MonoBehaviour
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
                    if (state < 1) MoveToState(++state);
                }
                else if (Content.offsetMin.x - startPositionX > 200)
                {
                    if (state > 0) MoveToState(--state);
                }
                else
                {
                    interactable = false;
                    Content.DOLocalMoveX(startPositionX, 0.3f).OnComplete(() => { interactable = true; });
                }
            }
            //if (Input.GetTouch(0).phase == TouchPhase.Began) startPositionX = Content.offsetMin.x;
            //if(Input.GetTouch(0).phase == TouchPhase.Ended)
            //{
            //    if (Content.offsetMin.x - startPositionX < -200)
            //    {
            //        if (state < 2) MoveToState(++state);
            //    }
            //    else if (Content.offsetMin.x - startPositionX > 200)
            //    {
            //        if (state > 0) MoveToState(--state);
            //    }
            //    else
            //    {
            //        interactable = false;
            //        Content.DOLocalMoveX(startPositionX, 0.3f).OnComplete(() => { interactable = true; });
            //    }
            //}
        }
    }
    private void MoveToState(int state)
    {
        interactable = false;
        Content.DOLocalMoveX(-state * 1920, 0.3f).OnComplete(() => { interactable = true; });
    }
}
