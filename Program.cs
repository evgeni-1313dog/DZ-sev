﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double[,] Create2dArray(int rows, int cols)
{
double[,] array = new double[rows, cols];
    for (int i = 0; i < rows; i++)
     {
for (int j = 0; j < cols; j++)
       {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
     return array;
  }
 void Show2dArray(double[,] array)
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
Console.Write("Enter numb of rols: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of cols: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = Create2dArray(m, n);
Console.WriteLine();
Show2dArray(array);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
/*
int[,] Create2dArray(int rows, int cols)
{
int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
     {
for (int j = 0; j < cols; j++)
       {
            array[i, j] = new Random().Next(1,20);
        }
    }
     return array;
  }
 void Show2dArray(int[,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             Console.Write(array[i, j] + "\t ");
         }
         Console.WriteLine();
     }
 }

 int[,] Change (int[,] array){
    int c;
     Console.Write("Enter numb of min: ");
     int min = Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter numb of max: ");
     int max = Convert.ToInt32(Console.ReadLine());
     if (array.GetLength(0) <= min || array.GetLength (1) <= max)
     Console.WriteLine($"Такого числа нет: {min} {max} ");
  
     else
    { c = array[min,max];
      Console.WriteLine($"Число под идеком i{min}, j{max}: {c}");
      
    }
    return array;
     
 }

 Console.Write("Enter numb of rows: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Enter numb of cols: ");
 int n = Convert.ToInt32(Console.ReadLine());
 
 int[,] array = Create2dArray(m, n);
 Show2dArray(array);
Change(array);
*/
 



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
float[,] Create2dArray(int rows, int cols)
{
float[,] array = new float[rows, cols];
    for (int i = 0; i < rows; i++)
     {
for (int j = 0; j < cols; j++)
       {
            array[i, j] = new Random().Next(1,9);
        }
    }
     return array;
  }
 void Show2dArray(float[,] array)
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
 void SumNumbers(float[,] array){
    
     for (int j = 0; j < array.GetLength(1); j++){
         float sum = 0;
         for (int i = 0; i < array.GetLength(0); i++)
         {
             sum += array[i,j];
         }
            
             Console.WriteLine($"{sum / array.GetLength(0)}");
         
         
     }
 }
Console.Write("Enter numb of rols: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter numb of cols: ");
int n = Convert.ToInt32(Console.ReadLine());
float [,] array = Create2dArray(m, n);
Console.WriteLine();
Show2dArray(array);
SumNumbers(array);
*/
