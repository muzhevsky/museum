public class MyList<T>
{
    private MyListItem<T> head;
    private MyListItem<T> end;
    public MyListItem<T> Head { get { return head; } set { head = value; } }
    public MyListItem<T> End { get { return end; } set { end = value; } }
    public int length { get; private set; }

    public void AddItem(T item){
        if(head == null)
        {
            head = new MyListItem<T>(item);
            end = head;
            head.Next = end;
        }
        else
        {
            MyListItem<T> myNewItem = new MyListItem<T>(item);
            end.Next = myNewItem;
            myNewItem.Prev = end;
            end = myNewItem;
        }
        length++;
    }
    public void RemoveLastItem()
    {
        if (length > 0)
        {
            end.Prev.Next = null;
            end = end.Prev;
            length--;
        }
    }
    public void RemoveItem(int index)
    {
        if (index < length && length> 0)
        {
            MyListItem<T> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Prev.Next = current.Next;
            current.Next.Prev = current.Prev;
            length--;
        }
    }
    public void AddItem(T item, int index)
    {
        if (index < length && length> 0){ 
            MyListItem<T> current = head;
            MyListItem<T> newItem = new MyListItem<T>(item);
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Prev.Next = newItem;
            current.Prev = newItem;
            newItem.Next = current;
            length++;
        }
    }
    public static T operator *(MyList<T> list, int index)  {
        MyListItem<T> current = list.head;
        for(int i = 0; i < index; i++){
            current = current.Next;
        }
        return current.Value;
    }
    public T GetItem(int index)
    {
        MyListItem<T> result = head;
        for(int i = 0;i < index; i++)
        {
            result = result.Next;
        }
        return result.Value;
    }
}

public class MyListItem<T>
{
    private T value;
    private MyListItem<T> prev;
    private MyListItem<T> next;
    public T Value{ get { return value; } set { this.value = value; } }
    public MyListItem<T> Prev { get { return prev; } set { prev = value; } }
    public MyListItem<T> Next { get { return next; } set { next = value; } }
    public MyListItem(T value)
    {
        this.Value = value;
    }
}
