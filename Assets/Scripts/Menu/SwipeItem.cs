using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class SwipeItem : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public InfiniteListItem<SwiperItemContent> content { get; private set; }
    [SerializeField] Image image;
    [SerializeField] DescriptionController descriptionController;
    [SerializeField] Swiper swiper;
    private void Update()
    {

        //if (Input.touchCount > 0)
        //{
        //    if (Input.GetTouch(0).position.y > transform.position.y - 200 && Input.GetTouch(0).position.y < transform.position.y + 200)
        //    {
        //        if (Input.GetTouch(0).phase == TouchPhase.Began)
        //        {
        //            startPosition = Input.GetTouch(0).position.x;
        //        }
        //        else if (Input.GetTouch(0).phase == TouchPhase.Ended)
        //        {
        //            if (startPosition - lastPosition > offset)
        //            {
        //                swiper.SwipeRight();
                        
        //            }
        //            else if (startPosition - lastPosition < -offset)
        //            {
        //                swiper.SwipeLeft();
        //            }
        //            startPosition = 0;
        //            lastPosition = 0;
        //        }
        //    }
        //}
    }
    public void SetContent(InfiniteListItem<SwiperItemContent> content)
    {
        this.content = content;
        image.sprite = content.value.GetImage();
    }
    public void Click()
    {
        descriptionController.SetContent(content.value);
        descriptionController.gameObject.SetActive(true);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        swiper.SetStartPosition(Input.mousePosition.x);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        if (!swiper.Swipe(Input.mousePosition.x))
        {
            descriptionController.SetContent(content.value);
            descriptionController.gameObject.SetActive(true);
        }
    }
}