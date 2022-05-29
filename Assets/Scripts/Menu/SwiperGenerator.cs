using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class SwiperGenerator : MonoBehaviour
{
    [SerializeField] GameObject swiperItem;
    [SerializeField] List<SwiperItemContent> swiperItemContents;
    [SerializeField] Transform content;
    [SerializeField] DescriptionController descriptionController;
    [SerializeField] UI_InfiniteScroll infiniteScroll;
    [SerializeField] float Width;
    [SerializeField] float Height;
    public void Start()
    {
        print("asd");
        LoadContent();
    }
    public void LoadContent()
    {
        for (int i = 0; i < swiperItemContents.Count; i++)
        {
            GameObject inst = Instantiate(swiperItem);
            SwipeItem swipeItem = inst.GetComponent<SwipeItem>();
            ((RectTransform)inst.transform).sizeDelta = new Vector2(Width, Height);
            inst.transform.SetParent(content.transform, true);
            inst.transform.position = new Vector3(inst.transform.position.x, inst.transform.position.y, 0);
            swipeItem.SetContent(swiperItemContents[i]);
            swipeItem.SetDescriptionController(descriptionController);
        }
        infiniteScroll?.ActivateSlider();
    }
}
