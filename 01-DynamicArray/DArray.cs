using System;

namespace DynamicArray;

public class DArray{

    private int[] data;
    private int count;
    private int capacity;

    public DArray(){
        capacity = 4;
        data = new int[capacity];
        count = 0;
    }

    public void Print(){
        for(int i=0; i < count ; i++){
            Console.Write($"{data[i]} ");
        }
        Console.WriteLine();
    }

    public void Add(int item){
        if (count == capacity){
            Expand();
        }
        data[count] = item;
        count++;
    }

    public void Expand(){
        capacity = capacity * 2;
        int[] newData = new int[capacity];
        Array.Copy(data, newData, count);
        data = newData;
    }

    public void RemoveAt(int index){
        if (count < capacity / 4){
            Shrink();
        }
        if (index < 0 || index >= count){
            return;
        }
        for(int i = index; i < count -1; i++){
            data[i] = data[i+1];
        }
        count--;
    }

    public void Shrink(){
        capacity = capacity / 2;
        int[] newData = new int[capacity];
        Array.Copy(data, newData, count);
        data = newData;
    }
}