using System;






struct Vector
{

    double x, y, z;
    

    public  Vector (double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;

    }



    public static Vector operator + (Vector v1, Vector v2)
    {

        Vector result = new Vector();

        result.x = v1.x + v2.x;

        result.y = v1.y + v2.y;

        result.z = v1.z + v2.z;

        return result;

    } 


    public static Vector operator * (Vector v1, Vector v2)

    {

        Vector result = new Vector();

        result.x = v1.x * v2.x;

        result.y = v1.y * v2.y;

        result.z = v1.z * v2.z;

        return result;

    }



    public static Vector operator * (Vector vec, int k)
    {
        Vector result = new Vector();
        result.x = vec.x * k;
        result.y = vec.y * k;
        result.z = vec.z * k;

        return result;

    }



     public static bool operator > (Vector vec1, Vector vec2)
    {
        double result1, result2;

        result1 = Math.Pow(vec1.x, 2) + Math.Pow(vec1.y, 2) + Math.Pow(vec1.z, 2);
        result2 = Math.Pow(vec2.x, 2) + Math.Pow(vec2.y, 2) + Math.Pow(vec2.z, 2);


        if (result1 > result2)
        
            return true;
        
        else
        
            return false;
        
    } 


    public static bool operator < (Vector vec1, Vector vec2)
    {
        double result1, result2;

        result1 = Math.Pow(vec1.x, 2) + Math.Pow(vec1.y, 2) + Math.Pow(vec1.z, 2);
        result2 = Math.Pow(vec2.x, 2) + Math.Pow(vec2.y, 2) + Math.Pow(vec2.z, 2);


        if (result1 < result2)

            return true;

        else

            return false;

    }





    public static bool operator ==(Vector v1, Vector v2)
    {



        return (v1.x == v2.x) && (v1.y == v2.y) && (v1.z == v2.z);

    }




    public static bool operator !=(Vector v1, Vector v2)
    {



        return (v1.x != v2.x) && (v1.y != v2.y) && (v1.z != v2.z);

    }






    public void print()
    {
        Console.WriteLine("{" + x + "," + y + "," + z + "}");
    }

}


namespace lab_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            Vector v1 = new Vector (1, 2, 3);
            Console.Write("Vector 1 = ");
            v1.print();
            Console.WriteLine();

            Vector v2 = new Vector (2, 3, 4);
            Console.Write("Vector 2 = ");
            v2.print();
            Console.WriteLine();


            Console.Write("Сложение векторов: ");
            Vector v3 = v1 + v2;
            v3.print();

            Console.WriteLine();


            Console.Write("Умножение векторов: ");
            Vector v4 = v1 * v2;
            v4.print();

            Console.WriteLine();
            Console.Write("Умножение на число: ");
            Vector v5 = new Vector(4, 5, 6);
            Vector v6 = v5 * 5;
            v6.print();

            Console.WriteLine();
            Console.Write("Сравнение векторов > " );
            Console.WriteLine(v1 > v2);


            Console.WriteLine();
            Console.Write("Сравнение векторов < ");
            Console.WriteLine(v1 < v2);

        }
    }
}
