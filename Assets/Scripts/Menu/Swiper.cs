using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Swiper : MonoBehaviour
{
    [SerializeField] List<RectTransform> swiperItemsRect;
    [SerializeField] List<SwipeItem> swiperItems;
    [SerializeField] List<float> swipeItemsPositions;
    [SerializeField] List<SwiperItemContent> _swiperItemContents;
    [SerializeField] InfiniteList<SwiperItemContent> swipeItemContents;
    float delta = 0;
    float startPosition = 0;
    float offset = 70;
    int lastIndex = 0;
    bool isSwipable = true;
    private void Start()
    {
        lastIndex = swiperItemsRect.Count - 1;
        swipeItemContents = new InfiniteList<SwiperItemContent>();
        swipeItemsPositions = new List<float>();
        foreach (SwiperItemContent item in _swiperItemContents)
        {
            swipeItemContents.Add(item);
        }
        foreach (RectTransform item in swiperItemsRect)
        {
            swiperItems.Add(item.GetComponent<SwipeItem>());
            swipeItemsPositions.Add(item.localPosition.x);
        }
        delta = swiperItemsRect[1].position.x - swiperItemsRect[0].position.x;
        for(int i = 0; i < swiperItems.Count; i++)
        {
            swiperItems[i].SetContent(swipeItemContents.GetItem(i));
        }
    }
    public void SetStartPosition(float startPostion)
    {
       this.startPosition = startPostion;
    }
    public bool Swipe(float mousePosition)
    {
        if (isSwipable)
        {
            if (startPosition - mousePosition > offset) { SwipeRight(); return true; }
            else if (startPosition - mousePosition < -offset) { SwipeLeft(); return true; }
            return false;
        }
        return true;
    }
    public void SwipeRight()
    {
        isSwipable = false;
        if (delta < 0) delta *= -1;
        RectTransform tempRect = swiperItemsRect[0];
        SwipeItem temp = swiperItems[0];
        for (int i = 0; i < swiperItemsRect.Count - 1; i++)
        {
            swiperItemsRect[i] = swiperItemsRect[i + 1];
            swiperItems[i] = swiperItems[i + 1];
        }
        swiperItemsRect[4] = tempRect;
        swiperItems[4] = temp;
        for (int i = 0; i < lastIndex; i++)
        {
            swiperItemsRect[i].DOLocalMoveX(swipeItemsPositions[i], 0.5f);
        }
        swiperItemsRect[lastIndex].DOLocalMoveX(swiperItemsRect[lastIndex].localPosition.x - delta, 0.5f).OnComplete(() =>
        {
            swiperItemsRect[lastIndex].Translate(new Vector3(swipeItemsPositions[lastIndex] - swiperItemsRect[lastIndex].localPosition.x, 0));
            swiperItems[lastIndex].SetContent(swiperItems[lastIndex - 1].content.next);
            isSwipable = true;
        });
    }
    public void SwipeLeft()
    {
        isSwipable = false;
        if (delta > 0) delta *= -1;
        RectTransform tempRect = swiperItemsRect[4];
        SwipeItem temp = swiperItems[4];
        for (int i = swiperItemsRect.Count - 1; i > 0; i--)
        {
            swiperItemsRect[i] = swiperItemsRect[i - 1];
            swiperItems[i] = swiperItems[i - 1];
        }
        swiperItemsRect[0] = tempRect;
        swiperItems[0] = temp;
        for (int i = 1; i < swiperItemsRect.Count; i++)
        {
            swiperItemsRect[i].DOLocalMoveX(swipeItemsPositions[i], 0.5f);
        }
        swiperItemsRect[0].DOLocalMoveX(swiperItemsRect[0].localPosition.x - delta, 0.5f).OnComplete(() =>
        {
            swiperItemsRect[0].Translate(new Vector3(swipeItemsPositions[0] - swiperItemsRect[0].localPosition.x, 0));
            swiperItems[0].SetContent(swiperItems[1].content.prev);
            isSwipable = true;
        });
    }
}
