using System;
using System.Collections;
using System.Collections.Generic;

class MyDictionary<TKey, TValue> : IEnumerable
{

    int counter = 0; // размерность 
    TKey[] key_array = null; // массив ключей 
    TValue[] value_array = null; // массив значений 

    public int Length // длинна словаря 
    {

        get
        {
            return this.counter;
        }

    }
    public void Add(TKey key, TValue val) // метод добавления 
    {
        this.counter++;

        Array.Resize(ref key_array, counter);
        key_array[counter - 1] = key;

        Array.Resize(ref value_array, counter);
        value_array[counter - 1] = val;
    }

    public TValue this[TKey key] // обращение по индексу 
    {
        get
        {
            int ind = 0;
            for (int i = 0; i < key_array.Length; i++)
            {
                if (key.Equals(key_array[i]))
                    ind = i;
            }
            return value_array[ind];
        }
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() // печать методом for each
    {
        for (int i = 0; i < key_array.Length; i++)
            yield return new KeyValuePair<TKey, TValue>(key_array[i], value_array[i]);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}



public class MainClass
{

    static void Main()
    {
        MyDictionary<int, string> dic = new MyDictionary<int, string>();
        Console.WriteLine("Печать словаря");
        dic.Add(1, "A");
        dic.Add(2, "B");
        dic.Add(3, "C");
        dic.Add(4, "D");
        dic.Add(5, "E");
        foreach (var item in dic)
        {
            Console.WriteLine("Ключ:" + item.Key + item.Value);
        }

        Console.WriteLine();
        Console.Write("Размерность словаря: ");
        Console.WriteLine(dic.Length);


        Console.WriteLine();
        Console.Write("Обращение по индексу: ");
        Console.WriteLine(dic[0]);
        
    }
    
}