using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class leftArrow : MyButton
{
    [SerializeField] Block2Swiper swiper;
    public override void OnClick()
    {
        swiper.MoveToState(0);
    }
}
