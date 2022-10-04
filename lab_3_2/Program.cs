using System;




interface Car
{
    String Name
    {
        get; set;
    }


    String Engine
    {
        get; set;
    }


    int MaxSpeed
    {
        get; set;
    }


    String ToString();


    void print();

}


class MyCar : Car
{


    public MyCar(string Name, string Engine, int MaxSpeed)
    {
        this.Name = Name;
        this.Engine = Engine;
        this.MaxSpeed = MaxSpeed;
    }

    public string Name
    {
        get; set;
    }

    public string Engine
    {
        get; set;
    }


    public int MaxSpeed
    {
        get; set;
    }


    public override string ToString()
    {
        return Name;
    }
        

    public void print()
    {

        Console.WriteLine(Name + " " + Engine + " " + MaxSpeed);

    }

    

}



    















class MyCar2 : Car, IEquatable<Car>
{
    public string Name
    {
        get; set;
    }

    public string Engine
    {
        get; set;
    }


    public int MaxSpeed
    {
        get; set;
    }


    public MyCar2(string Name, string Engine, int MaxSpeed)
    {
        this.Name = Name;
        this.Engine = Engine;
        this.MaxSpeed = MaxSpeed;
    }


    public override string ToString()
    {
        return Name;
    }


    public void print()
    {

        Console.WriteLine(Name + " " + Engine + " " + MaxSpeed);

    }

    public bool Equals(Car other)
    {
        return Name == other.Name && Engine == other.Engine && MaxSpeed == other.MaxSpeed;
    }


}








class CarsCatalog
{

    MyCar2[] mas;

   public CarsCatalog(params MyCar2[] m)
    {

        mas = new MyCar2[(int)m.Length];


        for (int i = 0; i < m.Length; i++)
            mas[i] = (MyCar2)Activator.CreateInstance(m[i].GetType(), m[i].Name, m[i].Engine, m[i].MaxSpeed);
    }



    public String this [int i] // индексатор
    {
        get

        {

            if (i < 0 || i >= mas.Length)
                return "Error";
            return mas[i].Name + " " + mas[i].Engine;
        }
    }


}






namespace lab_3_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyCar2 Ob1 = new MyCar2("Mers", "Benzin", 200);
            Ob1.print();
            Console.WriteLine(Ob1.ToString());

            MyCar Ob2 = new MyCar("Mers", "Benzin", 300);

            Console.WriteLine ( Equals(Ob2, Ob1));





            CarsCatalog cat = new CarsCatalog(new MyCar2("Mers", "Benzin", 200), new MyCar2("BMW", "Dizel", 400), new MyCar2("BMW", "Dizel", 500));

            for (int i = 0; i < 3; i ++ )
                Console.WriteLine(cat[i]);

        }







    }
}
