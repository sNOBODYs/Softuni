using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class ListyIterator<T> 
{
    private List<T> items;
    private int index = 0;
    public ListyIterator(params T[] elements)
    {
        items = new List<T>(elements);
    }

    public bool Move()
    {
        if (!HasNext())
        {
            return false;
        }
        index++;
        return true;
    }
    public bool HasNext()
    {
        if (index >= items.Count - 1)
        {
            return false;
        }

        return true;
    }
    public void Print()
    {
        if (items.Count == 0)
        {
            throw new InvalidOperationException();
        }
        Console.WriteLine(items[index]);
    }
}
