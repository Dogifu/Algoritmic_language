class MyMatrix
{
    public int n, m;
    public int[,] matrix;

    public MyMatrix(int n, int m, int k, int l) // Конструктор заполняющий матрицу
        //случайными числами 
    {
        Random R = new Random();

        this.n = n;
        this.m = m;
        matrix = new int[this.n, this.n];


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = R.Next(k, l);
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

    }

    // Задаем аксессоры для работы с полями вне класса MyMatrix
    // можно обращаться к любому элементу матрицы 
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



    // метод перезаполняющий матрицу иными случайными числами в заданном диапозоне 
     public void Fill()
     {



         Random random = new Random();

         for (int i = 0; i < n; i++)
         {
             for (int j = 0; j < m; j++)
             {
                 matrix[i, j] = random.Next(0, 10);
             }
         }

     }
    // метод изменяющий размерность матрицы 
     public void ChangeSize(int n, int m)
     {
         Random random = new Random();
         int[,] NewMatrix = new int[n, m];

         for (int i = 0; i < n; ++i)
         {
             for (int j = 0; j < m; ++j)
             {
                 if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
                 {
                     NewMatrix[i, j] = matrix[i, j];
                 }
                 else
                 {
                     NewMatrix[i, j] = random.Next(0, 10);
                 }
             }
         }

         matrix = NewMatrix;
     }


    // метод выводящий элементы матрицы из заданных диапозонов 
     public void ShowPartialy(int a, int b, int c, int d)
     {
         for (int i = a; i <= b; ++i)
         {
             for (int j = c; j <= d; ++j)
             {
                 Console.Write(matrix[i, j] + " ");
             }
             Console.WriteLine();
         }
     }
    // печать матрицы на консоль 
    public void Show()
    {
        ShowPartialy(0, matrix.GetLength(0) - 1, 0, matrix.GetLength(1) - 1);
    }

}


public class MainClass
{

    public static void Main()
    {

        Console.WriteLine("Исходная матрица ");
        Console.WriteLine();
        MyMatrix m = new MyMatrix(5, 5, 25, 50);
        Console.WriteLine();
        Console.WriteLine("Перезаполненная матрица");
        Console.WriteLine();
        m.Fill();
        m.Show();
        Console.WriteLine();
        Console.WriteLine("Измененная матрица");
        m.ChangeSize(7, 7);
        m.Show();
        Console.WriteLine();
        Console.WriteLine("Выведем элементы 1 и 2 строки и 1 и 2 столбца");
        m.ShowPartialy(0, 1, 0, 1);
        Console.WriteLine("Выведем какой-нибудь элемент матрицы");
        Console.WriteLine(m[0,0]);

    }
}