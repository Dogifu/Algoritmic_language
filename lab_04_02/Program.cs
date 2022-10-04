using System;
using System.Collections.Generic;

public class Car
{

    public string Name { get; set; }
    public int ProductionYear { get; set; }
    public double MaxSpeed { get; set; }

    public Car(string Name, int ProductionYear, double MaxSpeed)
    {
        this.MaxSpeed = MaxSpeed;
        this.Name = Name;
        this.ProductionYear = ProductionYear;
    }

}

 interface IComparer
{

    /* Сравнивает два объекта и возвращает значение, показывающее, что один
    объект меньше или больше другого или равен ему

    Параметры:
    x: Первый сравниваемый объект

    y: Второй сравниваемый объект

    Возврат:
    Знаковое целое число, которое определяет относительные значения x и y */

    int Compare(object x, object y);


}



public class CarComparer : IComparer<Car>
{

    public int a;

    public CarComparer(int a)
    {
        this.a = a;
        
    }

    public int Compare(Car x, Car y)
    {
        if (a == 3)
        {
            if (x.ProductionYear < y.ProductionYear)
            {
                return -1;
            }
            else
            {
                if (x.ProductionYear > y.ProductionYear)
                    return 1;
            }
        }
        else
        {
            if (a == 2)
            {
                if (x.MaxSpeed < y.MaxSpeed)
                {
                    return -1;
                }
                else
                {
                    if (x.MaxSpeed > y.MaxSpeed)
                        return 1;
                }
            }
            else
               
            {
                if (x.Name.Length < y.Name.Length)
                {
                    return -1;
                }
                else
                {
                    if (x.Name.Length > y.Name.Length)
                        return 1;
                }
            }
        }
        return 1;
    }

}








/* public class CarCatalog
{

    Car[] mas;
    public CarCatalog(params Car[] m)
    {
        mas = new Car[(int)m.Length];


        for (int i = 0; i < m.Length; i++)
            mas[i] = (Car)Activator.CreateInstance(m[i].GetType(), m[i].Name, m[i].ProductionYear, m[i].MaxSpeed);
    }




    public string this [int i]
    {
        get
        {
            
            return mas[i].Name + " " + mas[i].ProductionYear + " " + mas[i].MaxSpeed;
        }
    }

} */































namespace lab_04_02
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            
            
            Car[] mas = new Car[3]; // создаем массив элементов типа Car
            for(int i =0; i < mas.Length; i++)
            {
                mas[0] = new Car("Lexus", 2004, 225);
                mas[1] = new Car("BMW", 1999, 177);
                mas[2] = new Car("Toyota", 2002, 300);

                Console.WriteLine(mas[i].Name + " " + mas[i].ProductionYear + " " + mas[i].MaxSpeed);
            }


            Array.Sort(mas, new CarComparer(1)); // сортировка массива
            Console.WriteLine(new string('-',20));


            for (int i = 0; i < mas.Length; i ++)
            {
                Console.WriteLine(mas[i].Name + " " + mas[i].ProductionYear + " " + mas[i].MaxSpeed);
            }

        }
    }
}
