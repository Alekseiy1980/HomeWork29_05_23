// /*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// */
// double[,] CreateDoubleArray(int rows, int colums, int minValue, int maxValue)
// {
//    double[,] array = new double[rows, colums];
//    for (int i = 0; i < rows; i++)
//    {
//       for (int j = 0; j < colums; j++)
//       {
//          array[i, j] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 2);// метод Math.Round(new Random().NextDouble нужен для уменьшения чисел после запятой
//       }
//    }
//    return array;
// }

// void Print2DArray(double[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          Console.Write(array[i, j] + " ");
//       }
//       Console.WriteLine();
//    }
// }

// Console.WriteLine("Inpyt rows - ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt colums - ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt minValue - ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt maxValue - ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Print2DArray(CreateDoubleArray(rows, colums, minValue, maxValue));

/*
Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение
этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

// int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//    int[,] array = new int[rows, colums];
//    for (int i = 0; i < rows; i++)
//    {
//       for (int j = 0; j < colums; j++)
//       {
//          array[i, j] = new Random().Next(minValue, maxValue);
//       }
//    }
//    return array;
// }

// void Print2DArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//          Console.Write(array[i, j] + " ");
//       }
//       Console.WriteLine();
//    }

// }

// void Posishion2DArray(int[,] array, int xPos, int yPos)
// {
//    if ((xPos > 0 && xPos < array.GetLength(0) || (yPos > 0 && yPos < array.GetLength(1))))
//    {
//       Console.WriteLine($" На этой позиции {xPos}  {yPos} в массиве число {array[xPos, yPos]} ");
//    }
//    else Console.WriteLine($" На этой позиции {xPos}  {yPos} массива чисел нет");

// }


// Console.WriteLine("Inpyt rows - ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt colums - ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt minValue - ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inpyt maxValue - ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);
// Print2DArray(array);
// Console.WriteLine();
// Console.WriteLine("Введите координаты  - ");
// Console.WriteLine("По X оси - ");
// int xPos = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("По Y оси - ");
// int yPos = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Posishion2DArray(array, xPos, yPos);

/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue)
{
   int[,] array = new int[rows, colums];
   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < colums; j++)
      {
         array[i, j] = new Random().Next(minValue, maxValue);
      }
   }
   return array;
}

void Print2DArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine();
   }
}

void ArithmeticMeanInColumns(int[,] array)
{
   double arithmeticMean = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      arithmeticMean = 0;
      for (int j = 0; j < array.GetLength(1); j++)
      {
         arithmeticMean += array[j, i];
      }
      Console.Write(arithmeticMean / array.GetLength(1) + " ");
   }

}
Console.WriteLine("Inpyt rows - ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpyt colums - ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpyt minValue - ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpyt maxValue - ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2DRandomArray(rows, colums, minValue, maxValue);
Print2DArray(array);
Console.WriteLine();
ArithmeticMeanInColumns(array);