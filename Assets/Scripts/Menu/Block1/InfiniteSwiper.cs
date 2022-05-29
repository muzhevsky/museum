using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfiniteSwiper : MonoBehaviour
{
    [SerializeField] ScrollRect scrollRect;
    [SerializeField] float offset;
    float value;
    [SerializeField] float startPos;
    [SerializeField] float moveValue = 0.3f;
    private void Start()
    {
        scrollRect.onValueChanged.AddListener(SetValue);
    }
    public void ClearContent() {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
    }
    void SetValue(Vector2 pos)
    {
        value = pos.y;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition.y;
        }
        if (Input.GetMouseButtonUp(0))
        {
            print(((RectTransform)transform).position + " " + ((RectTransform)transform).localPosition) ;
            Transform first = transform.GetChild(0);
            Transform last = transform.GetChild(transform.childCount - 1);
            if (value < moveValue && value >= moveValue/2)
            {
                first.SetAsLastSibling();
                transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - Input.mousePosition.y - startPos); // 
            }
            else if (value < moveValue / 2)
            {
                first.SetAsLastSibling();
                first.SetAsLastSibling();
                transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y - 2 * (Input.mousePosition.y - startPos));
            }
            else if (value > 1- moveValue && value <= 1 - moveValue/2)
            {
                last.SetAsFirstSibling();
                transform.position = new Vector2(transform.position.x, transform.position.y + Input.mousePosition.y - startPos);
            }
            else if (value > 1 - moveValue / 2)
            {
                last.SetAsFirstSibling();
                last.SetAsFirstSibling();
                transform.position = new Vector2(transform.position.x, transform.position.y + 2 * (Input.mousePosition.y - startPos));
            }
            LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)transform);
        }
    }
}