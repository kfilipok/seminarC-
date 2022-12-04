﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double [,] CreateRandomDouble2DArray(){
    
    Console.Write("Введите Количетво строк в массиве: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Количетво столбцов в массиве: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение ячейки массива: ");
    double minValue = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите максимальное значение ячейки массива: ");
    double maxValue = Convert.ToDouble(Console.ReadLine());

    double [,] newArr = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            newArr[i, j] = Math.Round(minValue + rand.NextDouble()*maxValue - minValue, 2);
        }
    }
    return newArr;
}

void ShowDouble2DArray(double [,] arr){
    Console.WriteLine("-----------------------Начало double массива----------------------------");
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]} | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------Конец double массива----------------------------");
}


double[,] arr = CreateRandomDouble2DArray();
ShowDouble2DArray(arr);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int [,] CreateRandonm2DArray(){
    
    Console.Write("Введите Количетво строк в массиве: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите Количетво столбцов в массиве: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение ячейки массива: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение ячейки массива: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int [,] newArray = new  int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2DArray(int [,] arr){
    Console.WriteLine("-----------------------Начало int массива----------------------------");
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]} | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("-----------------------Конец int массива----------------------------");
}

int GetElement(int [,] array){
    Console.Write("Введите номер строки элемента массива: ");
    int row = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Введите номер столбца элемента массива: ");
    int column = Convert.ToInt32(Console.ReadLine()) - 1;

    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(i == row && j == column) {
                Console.WriteLine($"Элемент массива с заданными параметрами равен {array[i, j]}");
                return array[i, j];
            }
        }
    }
    Console.WriteLine($"Элемента не существует");
    return -1;
}
int [,] arr2 = CreateRandonm2DArray();
Show2DArray(arr2);
GetElement(arr2);


// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// // элементов в каждом столбце.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void Average(int [,] array){
    int columnsNum = array.GetLength(1);
    int rowsNum = array.GetLength(0);
    double [] sumOfColumnArr = new double[columnsNum];
    
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            sumOfColumnArr[j] += array[i, j];
        }
    }
    Console.WriteLine("Средние арифметические столбцов массива равны следующим числам:");
    for(int k = 0; k < sumOfColumnArr.Length; k++){
        Console.Write($" {Convert.ToDouble(sumOfColumnArr[k] / rowsNum)} |");
    }
}

Average(arr2);