using System;
class MyMatrix
{
    public int n, m;
    public int[,] matrix;

    public MyMatrix(int n, int m, int k, int l) // Конструктор
    {
        Random R = new Random();
        
        this.n = n;
        this.m = m;
        matrix = new int[this.n, this.n];


        for (int i = 0; i < n; i ++)
        {
            for (int j = 0; j < m; j ++)
            {
                matrix[i, j] = R.Next(k, l);
                Console.Write (matrix[i,j] + " ");
            }
            Console.WriteLine();
        }

    }

    // Задаем аксессоры для работы с полями вне класса MyMatrix

    public MyMatrix(int n, int m)
    {
        this.n = n;
        this.m = m;
        matrix = new int[this.n, this.n];
    }
    public int this[int i, int j] // Индексатор 
    {
        get
        {
            return matrix[i, j];
        }
        set
        {
            matrix[i, j] = value;
        }
    } 

    // Сложение матриц

    public static MyMatrix operator +(MyMatrix A, MyMatrix B)
    {
        MyMatrix resMass = new MyMatrix(A.n,A.m);
        for (int i = 0; i < A.n; i++)
        {
            for (int j = 0; j < B.n; j++)
            {
                resMass[i, j] = A[i, j] + B[i, j];
            }
        }
        return resMass;
    }

    // Вычитание матриц

    public static MyMatrix operator -(MyMatrix A, MyMatrix B)
    {
        MyMatrix resMass = new MyMatrix(A.n, A.m);
        for (int i = 0; i < A.n; i++)
        {
            for (int j = 0; j < B.n; j++)
            {
                resMass[i, j] = A[i, j] - B[i, j];
            }
        }
        return resMass;
    }

    // Умножение матриц
    public static MyMatrix operator *(MyMatrix A, MyMatrix B)
    {
        MyMatrix resMass = new MyMatrix(A.n,A.m);
        for (int i = 0; i < A.n; i++)
            for (int j = 0; j < B.m; j++)
                for (int k = 0; k < B.n; k++)
                    resMass[i, j] += A[i, k] * B[k, j];

        return resMass;
    }

    // Умножение матрицы на число
    public static MyMatrix operator *(MyMatrix A, int ch)
    {
        MyMatrix resMass = new MyMatrix(A.n, A.m);
        for (int i = 0; i < A.n; i++)
        {
            for (int j = 0; j < A.m; j++)
            {
                resMass[i, j] = A[i, j] * ch;
            }
        }
        return resMass;
    }

    // Деление матрицы на число

    public static MyMatrix operator /(MyMatrix a, int ch)
    {
        MyMatrix resMass = new MyMatrix(a.n, a.m);
        for (int i = 0; i < a.n; i++)
        {
            for (int j = 0; j < a.m; j++)
            {
                resMass[i, j] = a[i, j] / ch;
            }
        }
        return resMass;
    }

    public void print() // функция печати матрицы 
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}

namespace lab_04
{
    class MainClass
    {
        public static void Main()
        {
               Console.WriteLine("First matrix");
               MyMatrix mat1 = new MyMatrix(4, 4, 8, 8);
               Console.WriteLine();
               Console.WriteLine("Second matrix");
               MyMatrix mat2 = new MyMatrix(4, 4, 5, 5);
               Console.WriteLine();
               MyMatrix mat3;
               MyMatrix mat4;
               MyMatrix mat5;
               MyMatrix mat6;
               MyMatrix mat7;
               Console.WriteLine("Сложение матриц");
               mat3 = mat1 + mat2;
               mat3.print();
               Console.WriteLine();
               Console.WriteLine("Вычитание матриц");
               mat4 = mat1 - mat2;
               mat4.print();
               Console.WriteLine();
               Console.WriteLine("Умножение матрицы на число");
               mat5 = mat1 * 2;
               mat5.print();
               Console.WriteLine();
               Console.WriteLine("Деление матрицы на число");
               mat6 = mat1 / 4;
               mat6.print();
               Console.WriteLine();
               Console.WriteLine("Умножение матриц");
               mat7 = mat1 * mat2;
               mat7.print();
               Console.WriteLine();
               Console.WriteLine("Обращение к матрицы по индексу");
               Console.WriteLine(mat1[2,3]); 


        
        }
    }
}











