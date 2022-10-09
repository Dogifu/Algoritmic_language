using System.Collections;
using System.Collections.Generic;


class Car
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }
    public int ProductionYear { get; set; }

    public Car(string Name, int ProductionYear, int MaxSpeed)
    {
        this.Name = Name;
        this.MaxSpeed = MaxSpeed;
        this.ProductionYear = ProductionYear;
    }

    public void Print()
    {
        Console.WriteLine("Название: " + Name + " Год выпуска=" + ProductionYear + " Максимальная скорость: " + MaxSpeed );
    } 
}

 class CarComparer : IComparer<Car>
{
    public int Mode;
    public int Compare(Car x, Car y)
    {
        switch (Mode)
        {
         
            case 5: return x.Name.CompareTo(y.Name); // сортировка по названию
            case 4: return x.MaxSpeed.CompareTo(y.MaxSpeed); // сортировка по скорости 
            case 3: return x.ProductionYear.CompareTo(y.ProductionYear); // сортировка по году выпуска 
            case 1: return 0;
            case 2: return -1;
        }
        return 0;
    }
} 

class CarCatalog : IEnumerable
{
    int ch;
    Car[] mas;
    public CarCatalog(int ch, params Car[] m)
    {
        mas = new Car[m.Length];
        for (int i = 0; i < m.Length; i++)
            mas[i] = m[i];
        this.ch = ch;
    }
    // Implementation for the GetEnumerator method.
    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator)GetEnumerator(ch);
    }
    public IEnumerator<Car> GetEnumerator(int ch)
    {
 
         Car[] m = new Car[mas.Length];
         for (int i = 0; i < mas.Length; i++)
             m[i] = mas[i];
         CarComparer carComp = new CarComparer();
         carComp.Mode = ch;
         Array.Sort(m, carComp);
         for (int i = 0; i < m.Length; i++)
             yield return m[i]; 
       
    }
    public void Print()
    {
        foreach (var pos in mas)
            pos.Print();
    }
}


class MyMain { 
    static void Main()
    {
        int ch;
        string str;


        Console.WriteLine("Введите формат сортировки");
        Console.WriteLine("1. Итерация в прямом порядке" + '\t' +
            "2. Итерация в обратном порядке " + '\t' +
            "3. Итерация по году выпуска " + '\t' + "4. Итерация по максиммальной скорости" +
            '\t' + "5. Итерация по названию ");

        str = Console.ReadLine();
        ch = Convert.ToInt32(str);

        CarCatalog cars = new CarCatalog(ch, new Car("Mercedes", 1999, 99),
           new Car("Volvo", 2000, 100),
           new Car("Audi", 1986, 150),
           new Car("BMW", 1950, 101));

        Console.WriteLine("Исходный каталог");
        Console.WriteLine();
        cars.Print();
        
        Console.WriteLine();
        Console.WriteLine("Отсортированный каталог");
        Console.WriteLine();
        foreach (Car c in cars) c.Print();

        Console.ReadKey();
       

    }
}