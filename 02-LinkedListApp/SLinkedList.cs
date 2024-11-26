using System;

namespace LinkedListApp;

public class SLinkedList
{
    private Node? Head;
    private Node? Tail;
    public int Count { get; private set; }


    public SLinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    public void AddFront(int value)
    {
        Node newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
        }
        Count++;
    }

    public void AddBack(int value)
    {
        Node newNode = new Node(value);
        if (Tail == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
        }
        Count++;
    }

    public void Print()
    {
        Node? current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    public void AddAt(int value, int index){
        Node newNode = new Node(value);
        
        if(index < 0 || index > Count){
            Console.WriteLine("Invalid index");
            return;
        }
        
        if(index == 0){
            AddFront(value);
        }else if(index == Count){
            AddBack(value);
        }else{
            Node? temp = Head;
            for(int i = 0; i < index-1; i++){
                temp = temp.Next;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
            Count++;
        }
    }
}
