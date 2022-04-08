//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using DG.Tweening;
//public class Swiper : MonoBehaviour
//{
//    [SerializeField] List<SwipeItem> swiperItems;
//    [SerializeField] List<float> swipeItemsPositions;
//    [SerializeField] List<SwiperItemContent> _swiperItemContents;
//    [SerializeField] InfiniteList<SwiperItemContent> swipeItemContents;
//    [SerializeField] float delta = 0;
//    float startPosition = 0;
//    float offset = 70;
//    int lastIndex = 0;
//    bool isSwipable = true;

//    private void Start()
//    {
//        lastIndex = swiperItems.Count - 1;
//        swipeItemContents = new InfiniteList<SwiperItemContent>();
//        swipeItemsPositions = new List<float>();
//        foreach (SwiperItemContent item in _swiperItemContents)
//        {
//            swipeItemContents.Add(item);
//        }
//        for (int i = 0; i < swiperItems.Count; i++)
//        {
//            swiperItems[i].SetContent(swipeItemContents.GetItem(i));
//            swiperItems[i].SetRect();
//            swipeItemsPositions.Add(swiperItems[i].rectTransform.localPosition.x);
//        }
//        delta = swiperItems[1].rectTransform.position.x - swiperItems[0].rectTransform.position.x;
//    }
//    //private void Update()
//    //{
//    //    print(START+" "+content.localPosition.x+" "+ delta);
//    //    if (START - content.localPosition.x < -delta)
//    //    {
//    //        content.localPosition = new Vector3(START, content.position.y, content.position.z);
//    //        RectTransform tempRect = swiperItemsRect[0];
//    //        SwipeItem temp = swiperItems[0];
//    //        for (int i = 0; i < swiperItemsRect.Count - 1; i++)
//    //        {
//    //            swiperItemsRect[i] = swiperItemsRect[i + 1];
//    //            swiperItems[i] = swiperItems[i + 1];
//    //            swiperItemsRect[i].localPosition = new Vector3(swipeItemsPositions[i+1], 0, 0);
//    //        }
//    //        swiperItemsRect[4] = tempRect;
//    //        swiperItems[4] = temp;
//    //        swiperItemsRect[4].localPosition = new Vector3(swipeItemsPositions[0], 0, 0);
//    //        swiperItems[lastIndex].SetContent(swiperItems[lastIndex - 1].content.next);
//    //        content.DOLocalMoveX(START, 0);
//    //    }
//    //    else if (START - content.localPosition.x > delta)
//    //    {
//    //        content.localPosition = new Vector3(START, content.position.y, content.position.z);
//    //        RectTransform tempRect = swiperItemsRect[4];
//    //        SwipeItem temp = swiperItems[4];
//    //        for (int i = swiperItemsRect.Count - 1; i > 0; i--)
//    //        {
//    //            swiperItemsRect[i] = swiperItemsRect[i - 1];
//    //            swiperItems[i] = swiperItems[i - 1];
//    //            swiperItemsRect[i - 1].localPosition = new Vector3 (swipeItemsPositions[i], 0 ,0);
//    //        }
//    //        swiperItemsRect[0] = tempRect;
//    //        swiperItems[0] = temp;
//    //        swiperItemsRect[0].localPosition = new Vector3(swipeItemsPositions[0], 0, 0);
//    //        swiperItems[0].SetContent(swiperItems[1].content.prev);
//    //        content.DOLocalMoveX(START, 0);
//    //    }
//    //}
//    public void SetStartPosition(float startPostion)
//    {
//       this.startPosition = startPostion;
//    }
//    public bool Swipe(float mousePosition)
//    {
//        if (isSwipable)
//        {
//            if (startPosition - mousePosition > offset) { SwipeRight(); return true; }
//            else if (startPosition - mousePosition < -offset) { SwipeLeft(); return true; }
//            return false;
//        }
//        return true;
//    }
//    public void SwipeRight()
//    {
//        isSwipable = false;
//        if (delta < 0) delta *= -1;
//        SwipeItem temp = swiperItems[0];
//        for (int i = 0; i < swiperItems.Count - 1; i++)
//        {
//            swiperItems[i] = swiperItems[i + 1];
//        }
//        swiperItems[4] = temp;
//        for (int i = 0; i < lastIndex; i++)
//        {
//            swiperItems[i].rectTransform.DOLocalMoveX(swipeItemsPositions[i], 0.5f);
//        }
//        swiperItems[lastIndex].rectTransform.DOLocalMoveX(swiperItems[lastIndex].rectTransform.localPosition.x - delta, 0.5f).OnComplete(() =>
//        {
//            swiperItems[lastIndex].rectTransform.Translate(new Vector3(swipeItemsPositions[lastIndex] - swiperItems[lastIndex].rectTransform.localPosition.x, 0));
//            swiperItems[lastIndex].SetContent(swiperItems[lastIndex - 1].content.next);
//            isSwipable = true;
//        });
//    }
//    public void SwipeLeft()
//    {
//        isSwipable = false;
//        if (delta > 0) delta *= -1;
//        SwipeItem temp = swiperItems[4];
//        for (int i = lastIndex; i > 0; i--)
//        {
//            swiperItems[i] = swiperItems[i - 1];
//        }
//        swiperItems[0] = temp;
//        for (int i = 0; i < lastIndex; i++)
//        {
//            swiperItems[i].rectTransform.DOLocalMoveX(swipeItemsPositions[i], 0.5f);
//        }
//        swiperItems[0].rectTransform.DOLocalMoveX(swiperItems[0].rectTransform.localPosition.x - delta, 0.5f).OnComplete(() =>
//        {
//            swiperItems[0].rectTransform.Translate(new Vector3(swipeItemsPositions[0] - swiperItems[0].rectTransform.localPosition.x, 0));
//            swiperItems[0].SetContent(swiperItems[1].content.prev);
//            isSwipable = true;
//        });
//    }
//}
