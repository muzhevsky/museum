using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextHeroButton : Button
{
    [SerializeField] List<HeroCardItem> cardList;
    [SerializeField] HeroCardItem current;
    [SerializeField] int index = 0;
    void Start()
    {
        current = cardList[0];
    }
    public override void OnClick()
    {
        if (index == cardList.Count - 1)
        {
            current = cardList[0];
            index = 0;
        }
        else current = cardList[++index];
        current.SetContent();
    }
    public void SetActiveCard(HeroCardItem item, int index)
    {
        current = item;
        this.index = index;
    }
}
