using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroupPhotoDescription : MonoBehaviour
{
    [SerializeField] Text personName;
    [SerializeField] Text description;
    [SerializeField] Image photo;
    [SerializeField] GroupPhotoContent content;

    public void SetContent(GroupPhotoContent content)
    {
        this.content = content;
    }
    public void LoadContent()
    {
        personName.text = content.GetName();
        description.text = content.GetDescription();
        photo.sprite = content.GetImage();
    }
}
