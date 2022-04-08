using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteList<T> {
    public InfiniteListItem<T> start { get; private set; }
    public InfiniteListItem<T> last { get; private set; }
    public void Add(T item)
    {
        InfiniteListItem<T> newItem = new InfiniteListItem<T>(item);
        if (start == null) {
            start = newItem;
            last = newItem;
        }
        else
        {
            last.SetNext(newItem);
            newItem.SetPrev(last);
            last = newItem;
            newItem.SetNext(start);
            start.SetPrev(last);
        }
    }
    public InfiniteListItem<T> GetItem(int index)
    {
        int i = 0;
        InfiniteListItem<T> item = start;
        while (i < index)
        {
            item = item.next;
            i++;
        }
        return item;
    }
}
