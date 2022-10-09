class MyList<T>


{

    T[] list = new T[0];

    public T this[int index]
    {
        get
        {
            return list[index];
        }

        set
        {
            list[index] = value;
        }
    }

    public int Count // аксессор получающий размерность списка 
    {
        get
        {
            return list.Length;
        }
    }



    public void Add(T value) // добавление элемента в список 
    {
        int len = list.Length;
        T[] new_list = new T[len + 1];
        for (int i = 0; i < list.Length; i ++)
        {
            new_list[i] = list[i];
        }

        new_list[len] = value;
        list = new_list;
    }



    public void print() // метод печати списка 
    {
        for (int i = 0; i < list.Length; i ++)
        {
            Console.WriteLine(list[i]);
        }
    }

}

class MainProgram
{

   public static void Main()




    {
        MyList<int> list = new MyList<int>();
        Console.WriteLine("Печать list");
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.print();
        Console.WriteLine("Обращение к элементу по индексу");
        Console.WriteLine(list[0]);
        Console.WriteLine("Длина списка");
        Console.WriteLine(list.Count);
    }



}