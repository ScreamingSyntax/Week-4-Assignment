using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Stack<T>
    {
    private List<T> items;
    public Stack() {
        this.items = [];
    }
    public void Push(T item)

    {
        this.items.Add(item);
        Console.WriteLine($"The list after push is {string.Join(' ',string.Join(' ',this.items))}");

    }
    public void Pop()
    {
        this.items.RemoveAt(this.items.Count - 1);
    
    }
     public void Peek()
    {
        Console.WriteLine($"This is the last element of the list {this.items.ElementAt<T>(this.items.Count-1)}");
    }
    public void getItems()
    {
        Console.WriteLine($"This is the list {string.Join(' ',this.items)}");
    }


    public bool isEmpty()
    {
        return !(this.items.Any());
    }

}

