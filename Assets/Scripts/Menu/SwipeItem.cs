using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class SwipeItem : Button
{
    [SerializeField] SwiperItemContent content;
    [SerializeField] Image image;
    [SerializeField] DescriptionController descriptionController;
    private void Start()
    {
        image.sprite = content.GetImage();
    }
    public override void OnClick()
    {
        descriptionController.gameObject.SetActive(true);
        descriptionController.SetContent(content,(RectTransform)transform);
    }
}