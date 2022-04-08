using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteListItem<T>
{
    public T value { get; private set; }
    public InfiniteListItem<T> next { get; private set; }
    public InfiniteListItem<T> prev { get; private set; }
    public void SetValue(T value)
    {
        this.value = value;
    }
    public void SetNext(InfiniteListItem<T> next)
    {
        this.next = next;
    }
    public void SetPrev(InfiniteListItem<T> prev)
    {
        this.prev = prev;
    }
    public InfiniteListItem(T value){
        this.value = value;
    }
}
