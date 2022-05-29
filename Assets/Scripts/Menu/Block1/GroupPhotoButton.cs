using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupPhotoButton : MyButton
{
    [SerializeField] GroupPhotoContent content;
    [SerializeField] GroupPhotoDescription descriptionController;
    public override void OnClick()
    {
        descriptionController.gameObject.SetActive(true);
        descriptionController.SetContent(content);
        descriptionController.LoadContent();
    }
}
