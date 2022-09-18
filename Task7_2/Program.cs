// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void PrintArray(double[,] table)
            {
            for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                        {
                            Console.Write(table[i,j] + "\t" );
                        }
                    Console.WriteLine();
                }
            }
double[,] FillArray (int m, int n)
            {
                double[,] array = new double[m,n];
                for (int i=0;i<m;i++)
                    {
                        for (int j=0;j<n;j++)
                            array[i,j] = new Random().Next(1,100);
                    }
                return array;
            }
Console.Write ("Введите количество строк двумерного массива ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32 (Console.ReadLine());       
double[,] mas = FillArray(m,n);
PrintArray(mas);
Console.WriteLine("Введите номер строки и номер столбца искомого элемента.");
Console.Write("Номер строки: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Номер столбца: ");
int b = Convert.ToInt32 (Console.ReadLine());
if (a>m || b>n) Console.Write("Такого элемента нет");
else Console.Write($"Это элемент {mas[a-1,b-1]}");
