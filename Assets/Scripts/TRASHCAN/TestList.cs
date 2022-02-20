using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestList : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyList<int> a = new MyList<int>();
        a.AddItem(7);
        for(int i = 0; i < a.length; i++)
        {
            print(a * i);
        }
        a.AddItem(5);
        for (int i = 0; i < a.length; i++)
        {
            print(a * i);
        }
        a.AddItem(12);
        for (int i = 0; i < a.length; i++)
        {
            print(a * i);
        }
        a.RemoveItem(1);
        for (int i = 0; i < a.length; i++)
        {
            print(a*i);
        }
        a.AddItem(1, 1);
        for (int i = 0; i < a.length; i++)
        {
            print(a * i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
