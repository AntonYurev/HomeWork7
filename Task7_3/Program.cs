// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
double average = 0;
for(int i=0;i<n;i++)
    {
        for(int j=0;j<m;j++)
            {
               average=average+mas[j,i]; 
            }
        average=Math.Round(average/m,2);
        Console.WriteLine($"среднее арифметическое {i+1} столбца равно {average}");
        average=0;    
    }
