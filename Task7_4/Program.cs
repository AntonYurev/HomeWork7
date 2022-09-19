//Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры.
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
void PrintArray(int [,] table)
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
int[,] FillArray (int m, int n)
            {
                int[,] array = new int[m,n];
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
int[,] mas = FillArray(m,n);
Console.WriteLine("    Наш массив: ");
PrintArray(mas);
int min = mas[0,0];int a=0; // Сортируем методом пузырька по столбцам
for(int i=0;i<n;i++)
    {
        min=mas[0,i];
        while (a<m-1)
        {
        for(int j=a;j<m-1;j++)
            {
               if (mas[j+1,i] < min) 
                {
                    min=mas[j+1,i]; mas[j+1,i]=mas[a,i];mas[a,i]=min;
                }
            }
        min=mas[a+1,i];a++;  
        }  
    a=0; 
    }
a=0;
for(int i=0;i<m;i++)  // Сортируем по строкам
    {
        min=mas[i,0];
        while (a<n-1)
        {
        for(int j=a;j<n-1;j++)
            {
               if (mas[i,j+1] < min) 
                {
                    min=mas[i,j+1]; mas[i,j+1]=mas[i,a];mas[i,a]=min;
                }
            }
        a++;min=mas[i,a];    
        }  
    a=0;
    }    
Console.WriteLine("     Отсортированный массив: ");
PrintArray(mas);


