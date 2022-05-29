using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public sealed class SwipeItem : MyButton
{
    [SerializeField] SwiperItemContent content;
    [SerializeField] Image image;
    [SerializeField] DescriptionController descriptionController;
    private void Start()
    {
        SetImage();
    }
    public override void OnClick()
    {
        descriptionController.gameObject.SetActive(true);
        descriptionController.SetContent(content);
        descriptionController.LoadContent((RectTransform)transform);
    }
    public void SetImage()
    {
        image.sprite = content?.GetImage(0);
    }
    public void SetContent(SwiperItemContent content)
    {
        this.content = content;
        SetImage();
    }
    public void SetDescriptionController(DescriptionController controller)
    {
        descriptionController = controller;
    }
}