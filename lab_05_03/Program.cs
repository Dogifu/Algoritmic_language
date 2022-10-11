using System;
using System.Collections;
using System.Collections.Generic;

class MyDictionary<TKey, TValue> : IEnumerable
{

    int counter = 0; // размерность 
    TKey[]? key_array; // массив ключей 
    TValue[]? value_array; // массив значений 

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

    public TValue this[TKey key] // обращение по индексу (ключу)
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


        set // метод для установки нового значения в словаре  
        {
            int ind = 0;
            for (int i = 0; i < key_array.Length; i++)
            {
                if (key.Equals(key_array[i]))
                    ind = i;
            }
            
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
        MyDictionary<string, int> dic = new MyDictionary<string, int>();
        Console.WriteLine("Печать словаря");
        dic.Add("A", 5);
        dic.Add("B", 7);
         dic.Add("C", 8);

        dic["A"] = 6; // задаем новое значение 

        dic["B"] = 9; // задаем новое значение 
            Console.WriteLine(dic["B"] = 9); // выводим на консоль 
        Console.WriteLine(dic["A"] = 6 );

        foreach (var item in dic) // метод печати
        {
            Console.WriteLine("Ключ:" + item.Key + item.Value);
        }

        Console.WriteLine();
        Console.Write("Размерность словаря: ");
        Console.WriteLine(dic.Length);

        Console.WriteLine();
        Console.Write("Обращение по индексу: ");
        Console.WriteLine(dic["A"]); 
        
    }
    
}