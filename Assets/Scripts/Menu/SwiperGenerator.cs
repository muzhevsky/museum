using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwiperGenerator : MonoBehaviour
{
    [SerializeField] GameObject swiperItem;
    [SerializeField] List<SwiperItemContent> swiperItemContents;
    [SerializeField] Transform Content;
    [SerializeField] DescriptionController descriptionController;
    [SerializeField] float Width;
    [SerializeField] float Height;

    private void Start()
    {
        LoadContent();
    }
    public void LoadContent()
    {
        for (int i = 0; i < swiperItemContents.Count; i++)
        {
            GameObject inst = Instantiate(swiperItem);
            SwipeItem swipeItem = inst.GetComponent<SwipeItem>();
            ((RectTransform)inst.transform).sizeDelta = new Vector2(Width, Height);
            inst.transform.SetParent(Content.transform, true);
            inst.transform.position = new Vector3(inst.transform.position.x, inst.transform.position.y, 0);
            swipeItem.SetContent(swiperItemContents[i]);
            swipeItem.SetDescriptionController(descriptionController);
        }
    }

    public void ClearContent()
    {
        for(int i = 0; i < Content.transform.childCount; i++)
        {
            Destroy(Content.GetChild(i).gameObject);
        }
    }
}
